using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace CopyWF
{
    public partial class Form1 : Form
    {
        //勾子管理类  
        private KeyboardHookLib _keyboardHook = null;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
           /* if (e.Control & (e.KeyCode == Keys.D1))//ctrl+f  
            {
                CopyDone(@SourcePath1.Text, @TargetPath1.Text);
            }
            else if (e.Control & (e.KeyCode == Keys.D2))
            {
                CopyDone(@SourcePath2.Text, @TargetPath2.Text);
            }
            else if(e.Control & (e.KeyCode == Keys.D3))
            {
                CopyDone(@SourcePath3.Text, @TargetPath3.Text);
            }
            else
            {

            }*/
        }

        private void InitialCltr()
        {
            string filepath = @"C:\Users\Administrator\Documents\CopyAuto\Settings.ini";
            bool fgExist = File.Exists(filepath);

             if ( fgExist )
             {
                FileStream fsFile = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader srFile = new StreamReader(fsFile);
                string strText = srFile.ReadToEnd();

                SourcePath1.Text = GetMiddleStr("SourcePath1=", "\r|\n", strText);
                Console.WriteLine(SourcePath1.Text);

                SourcePath2.Text = GetMiddleStr("SourcePath2=", "\r|\n", strText);
                Console.WriteLine(SourcePath2.Text);

                SourcePath3.Text = GetMiddleStr("SourcePath3=", "\r|\n", strText);
                Console.WriteLine(SourcePath3.Text);

                TargetPath1.Text = GetMiddleStr("TargetPath1=", "\r|\n", strText);
                Console.WriteLine(TargetPath1.Text);

                TargetPath2.Text = GetMiddleStr("TargetPath2=", "\r|\n", strText);
                Console.WriteLine(TargetPath2.Text);

                TargetPath3.Text = GetMiddleStr("TargetPath3=", "\r|\n", strText);
                Console.WriteLine(TargetPath3.Text);

                string strCheckDll = GetMiddleStr("CheckDll=", "\r|\n", strText);
                checkDLL.Checked = (strCheckDll == "True") ? true : false;

                string strCheckExe = GetMiddleStr("CheckExe=", "\r|\n", strText);
                checkEXE.Checked = (strCheckExe == "True") ? true : false;

                string strCheckAll = GetMiddleStr("CheckAll=", "\r|\n", strText);
                checkAll.Checked = (strCheckAll == "True") ? true : false;

                srFile.Close();
                fsFile.Close();
             }
             
        }
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void SetFolderBowserDialog( FolderBrowserDialog fbdFoldeBrowerDialog, TextBox ttTextBox )
        {
            fbdFoldeBrowerDialog.Description = "请选择文件夹";
            DialogResult drFBD1Ret = fbdFoldeBrowerDialog.ShowDialog();

            if ((drFBD1Ret == DialogResult.OK))
            {
                ttTextBox.Text = @fbdFoldeBrowerDialog.SelectedPath;
                Console.WriteLine(ttTextBox.Text);
            }
            else if (drFBD1Ret == DialogResult.Yes)
            {
                ttTextBox.Text = @fbdFoldeBrowerDialog.SelectedPath;
            }
            else if ((drFBD1Ret == DialogResult.Cancel))
            {
            }
            else
            {
            }

            Console.WriteLine(ttTextBox.Text);
        }

        private void CopyDone( string strSourcePath, string strTargetPath )
        {
            try
            {

                DriveInfo[] s = DriveInfo.GetDrives();

                foreach (DriveInfo drive in s)
                {
                    if (drive.DriveType == DriveType.Removable)
                    {
                        string strUSBPath = GetMiddleStr("USB=", ";|\r|\n", strTargetPath);

                        if (strUSBPath == drive.VolumeLabel)
                        {
                            strTargetPath = drive.Name.ToString() + "\\Update";
                        }
                    }
                }


                // Determine whether the directory exists.
                bool fgSourcePathExist = Directory.Exists(@strSourcePath);

                if (false == fgSourcePathExist)
                {
                    label1.Text = "\""+@strSourcePath + "\" not exist!";
                    return;
                }

                bool fgTargetPathExist = Directory.Exists(@strTargetPath);

                if (true == fgTargetPathExist)
                {
                    // Delete the target to ensure it is not there.
                    Directory.Delete(@strTargetPath, true);
                    Console.WriteLine("Delet TargetPath1!");
                }

                Directory.CreateDirectory(@strTargetPath);

                //使用
                bool fgCopyDll = checkDLL.Checked;
                bool fgCopyExe = checkEXE.Checked;
                bool fgCopyAll = checkAll.Checked;

                if (fgCopyAll)
                {
                    copyDir("复制", @strSourcePath, @strTargetPath, ".*");
                }
                else
                {
                    if (fgCopyDll)
                    {
                        copyDir("复制", @strSourcePath, @strTargetPath, ".dll");
                    }

                    if (fgCopyExe)
                    {
                        copyDir("复制", @strSourcePath, @strTargetPath, ".exe");
                    }
                }
            }

            catch (Exception error)
            {
                Console.WriteLine("The process failed: {0}", error.ToString());
            }
        }

        public void copyDir(string workWhat, string fromDir, string toDir, string extension)
        {
            string[] files = Directory.GetFiles(@fromDir);
            foreach (string file in files)
            {
                FileInfo fiE = new FileInfo(@file);
                //loading文本说明 赋值
                if ( ".*" == extension )
                {
                    File.Copy(@file, @toDir + "\\" + Path.GetFileName(@file), true);
                }
                else if (workWhat == "复制")
                {
                    if (fiE.Extension == extension)
                    {
                        File.Copy(@file, @toDir + "\\" + Path.GetFileName(@file), true);
                    }
                }
                else if (workWhat == "剪切")
                {
                    if (fiE.Extension == extension)
                    {
                        File.Move(@file, @toDir + "\\" + Path.GetFileName(@file));
                    }
                }
                else if (workWhat == "删除")
                {
                    if (fiE.Extension == extension)
                    {
                        File.Delete(@file);
                    }
                }
                else
                {

                }
            }
            //子目录处理
           /* string[] dirs = Directory.GetDirectories(@fromDir);
            foreach (string dir in dirs)
            {
                if (!Directory.Exists(@toDir + "\\" + Path.GetFileName(@dir)))
                {
                    Directory.CreateDirectory(@toDir + "\\" + Path.GetFileName(@dir));
                }
                copyDir(@dir, @toDir + "\\" + Path.GetFileName(@dir));
            }*/
        }

        //Copy1
        private void Copy1_Click(object sender, EventArgs e)
        {         
            CopyDone(@SourcePath1.Text, @TargetPath1.Text);
        }

        private void SelSourcePath1_Click(object sender, EventArgs e)
        {
            SetFolderBowserDialog(folderBrowserDialog1, SourcePath1 );
        }

        private void SelTargetPath1_Click(object sender, EventArgs e)
        {
            SetFolderBowserDialog(folderBrowserDialog1, TargetPath1);
        }


        //Copy2
        private void Copy2_Click(object sender, EventArgs e)
        {
            CopyDone(@SourcePath2.Text, @TargetPath2.Text);
        }

        private void SelSourcePath2_Click(object sender, EventArgs e)
        {
            SetFolderBowserDialog(folderBrowserDialog1, SourcePath2);
            Console.WriteLine(SourcePath2.Text);
        }

        private void SelTargetPath2_Click(object sender, EventArgs e)
        {
            SetFolderBowserDialog(folderBrowserDialog1, TargetPath2);
        }        

        //Copy3
        private void Copy3_Click(object sender, EventArgs e)
        {
            CopyDone(@SourcePath3.Text, @TargetPath3.Text);
        }

        private void SelSourcePath3_Click(object sender, EventArgs e)
        {
            SetFolderBowserDialog(folderBrowserDialog1, SourcePath3);
        }

        private void SelTargetPath3_Click(object sender, EventArgs e)
        {
            SetFolderBowserDialog(folderBrowserDialog1, TargetPath3);
        }

        //Save
        private void Save_Click(object sender, EventArgs e)
        {
            string filepath = @"C:\Users\Administrator\Documents\CopyAuto\Settings.ini";
            string sPath = @"C:\Users\Administrator\Documents\CopyAuto";
            StreamWriter swSettings;
            FileStream fsFile;
            bool fgExist = File.Exists(filepath);

            if (!Directory.Exists(sPath))
            {
                Directory.CreateDirectory(sPath);
            }

            //如文件不存在
            if ( false == fgExist )
            {
                //创建文件读写流,类型为创建新文件
                fsFile = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                swSettings = new StreamWriter(fsFile);
            }
            //否则,如果文件存在
            else
            {
                //创建文件读写流, 类型为打开已有的文件
                fsFile = new FileStream(filepath, FileMode.Open, FileAccess.Write);
                swSettings = new StreamWriter(fsFile);
            }

            swSettings.WriteLine("TargetPath1="+TargetPath1.Text);//开始写入值
            swSettings.WriteLine("TargetPath2="+TargetPath2.Text);//开始写入值
            swSettings.WriteLine("TargetPath3="+TargetPath3.Text);//开始写入值

            swSettings.WriteLine("SourcePath1="+SourcePath1.Text);//开始写入值
            swSettings.WriteLine("SourcePath2="+SourcePath2.Text);//开始写入值
            swSettings.WriteLine("SourcePath3="+SourcePath3.Text);//开始写入值

            swSettings.WriteLine("CheckDll=" + checkDLL.Checked);
            swSettings.WriteLine("CheckExe=" + checkEXE.Checked);
            swSettings.WriteLine("CheckAll=" + checkAll.Checked);
            swSettings.Close();
            fsFile.Close();

          
        }

        private string GetMiddleStr(string strStart, string strEnd, string strSourceStr)
        {
            string strRet = "";
            Regex rgSourcePath1 = new Regex("(?<=(" + strStart + "))[.\\s\\S]*?(?=("+ strEnd+"))", RegexOptions.Multiline | RegexOptions.Singleline);

            Match mStrMatch = rgSourcePath1.Match(strSourceStr);

            if ( 0 != mStrMatch.Length )
            {
                strRet = mStrMatch.Value;
            }           

            return strRet;
        }

        /// <summary>  
        /// 客户端键盘捕捉事件.  
        /// </summary>  
        /// <param name="hookStruct">由Hook程序发送的按键信息</param>  
        /// <param name="handle">是否拦截</param>  
        public void KeyPress(KeyboardHookLib.HookStruct hookStruct, out bool handle)
        {
            handle = false; //预设不拦截任何键  

            /* if (hookStruct.vkCode == 91) // 截获左win(开始菜单键)  
             {
                 handle = true;
             }

             if (hookStruct.vkCode == 92)// 截获右win  
             {
                 handle = true;
             }

             //截获Ctrl+Esc  
             if (hookStruct.vkCode == (int)Keys.Escape && (int)Control.ModifierKeys == (int)Keys.Control)
             {
                 handle = true;
             }

             //截获alt+f4  
             if (hookStruct.vkCode == (int)Keys.F4 && (int)Control.ModifierKeys == (int)Keys.Alt)
             {
                 handle = true;
             }

             //截获alt+tab  
             if (hookStruct.vkCode == (int)Keys.Tab && (int)Control.ModifierKeys == (int)Keys.Alt)
             {
                 handle = true;
             }

             //截获F1  
             if (hookStruct.vkCode == (int)Keys.F1)
             {
                 handle = true;
             }

             //截获Ctrl+Alt+Delete  
             if ((int)Control.ModifierKeys == (int)Keys.Control + (int)Keys.Alt + (int)Keys.Delete)
             {
                 handle = true;
             }

             //如果键A~Z  
             if (hookStruct.vkCode >= (int)Keys.A && hookStruct.vkCode <= (int)Keys.Z)
             {
                 //挡掉G键，想要挡掉哪些键就把下面的G换成那个要挡掉的键，同理可以挡多个  
                 if (hookStruct.vkCode == (int)Keys.G)
                 {
                     hookStruct.vkCode = (int)Keys.None; //设键为0  
                 }

                 handle = true;
             }
             */
            if  ((Control.ModifierKeys == Keys.Control) && (hookStruct.vkCode == (int)Keys.D1))
            {
                CopyDone(@SourcePath1.Text, @TargetPath1.Text);
                handle = true;
            }
            else if ((Control.ModifierKeys == Keys.Control) && (hookStruct.vkCode == (int)Keys.D2))
            {
                CopyDone(@SourcePath2.Text, @TargetPath2.Text);
                handle = true;
            }
            else if ((Control.ModifierKeys == Keys.Control) && (hookStruct.vkCode == (int)Keys.D3))
            {
                CopyDone(@SourcePath3.Text, @TargetPath3.Text);
                handle = true;
            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form1_Load");

            InitialCltr();

            InitialKeyBoardHook();

        }

        private void InitialKeyBoardHook()
        {
            //安装勾子  
            _keyboardHook = new KeyboardHookLib();
            _keyboardHook.InstallHook(this.KeyPress);
        }

        private void UnInitialKeyBoardHook()
        {
            //取消勾子  
            if (_keyboardHook != null)
            {
                _keyboardHook.UninstallHook();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnInitialKeyBoardHook();

            System.Environment.Exit(0);
        }

        private void checkDLL_CheckedChanged(object sender, EventArgs e)
        {
            if (true == checkDLL.Checked)
            {
                checkAll.Checked = false;
            }
        }

        private void checkEXE_CheckedChanged(object sender, EventArgs e)
        {
            if (true == checkEXE.Checked)
            {
                checkAll.Checked = false;
            }
        }

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if ( true == checkAll.Checked )
            {
                checkDLL.Checked = false;
                checkEXE.Checked = false;
            }
        }
    }
}
