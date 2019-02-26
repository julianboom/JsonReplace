using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReplaceCodeTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            string replaceText = this.txtReplaceText.Text.Trim();

            string flowid = this.FlowID.Text.Trim();
            string typeid = this.TypeID.Text.Trim();

            if (string.IsNullOrWhiteSpace(replaceText)||string.IsNullOrWhiteSpace(flowid) ||string.IsNullOrWhiteSpace(typeid))
            {
                MessageBox.Show("请输入需要替换的文本");
                return;
            }
            try
            {
                ReplaceModel model = JsonConvert.DeserializeObject<ReplaceModel>(replaceText);
                if (model != null)
                {
                    List<StepModel> listStep = model.Steps;
                    if (listStep != null && listStep.Count > 0)
                    {
                        foreach (var item in listStep)
                        {
                            Guid newGuid = Guid.NewGuid();
                            replaceText = replaceText.Replace(item.Id, newGuid.ToString());
                        }
                    }
                    replaceText = replaceText.Replace(model.ID,flowid).Replace(model.Type, typeid);
                }

                this.txtNeedText.Text = replaceText;
                MessageBox.Show("替换成功");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtReplaceText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void txtNeedText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


    public class ReplaceModel
    {
        public List<StepModel> Steps { get; set; }
        public string ID { get; set; }
        public string Type { get; set; }
    }
    public class StepModel
    {
        public string Id { get; set; }
    }
}
