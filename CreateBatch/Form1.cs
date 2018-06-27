using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateBatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LogClass LC = new LogClass();
            int i = 0;
            i = int.Parse(tbCount.Text);
            int fileNum = 0;
            int lines = 0;
            //for(int j=0;j<=i;j++)
            //{
            //    if (tbListContent1.Lines.Length > 0)
            //    {
            //        for (int k = 1; k < tbListContent1.Lines.Length; k++)   //添加10行数据
            //        {
            //            LC.WriteBatch(tbStart.Text.Replace("&Value1",tbListContent1.Lines[k]), "GenScript" + j + ".bat");
            //        }
            //    }               
            //}
            
            //LC.WriteLogFile(tbStart.Text, "111.bat");
            //LC.WriteBatch(tbStart.Text, "1112.bat");

            if (tbListContent1.Lines.Length > 0)
            {
                for (int k = 1; k < tbListContent1.Lines.Length+1; k++)   //添加10行数据
                {
                    if (k % i == 0)
                    {
                        Console.WriteLine(k % i);
                        LC.WriteBatch(tbStart.Text.Replace("&Value1", tbListContent1.Lines[k-1]), "GenScript" + fileNum + ".bat");
                        fileNum++;
                    }
                    else
                    {
                        Console.WriteLine(k % i);
                        LC.WriteBatch(tbStart.Text.Replace("&Value1", tbListContent1.Lines[k-1]), "GenScript" + fileNum + ".bat");

                    }

                    //for(int m=lines;m<lines+i;m++)
                    //{
                    //    LC.WriteBatch(tbStart.Text.Replace("&Value1", tbListContent1.Lines[m]), "GenScript" + fileNum + ".bat");
                    //    fileNum++;
                    //}
                    //lines = lines + i;
                }
            }        
        }

        private void btnBrowserV1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog fileDialog = new OpenFileDialog();
            //筛选  
            //fileDialog.Filter = "Word Documents|*.docx" +  
            //                            "|Excel Worksheets|*.xlsx" +  
            //                            "|PowerPoint Presentations|*.pptx" +  
            //                          "|Office Files|*.docx;*.xlsx;*.pptx" +  
            //                            "|All Files|*.*";  
           // if (fileDialog.ShowDialog().Equals(DialogResult.OK))
           // {
                //显示选择文件  
                //MessageBox.Show(fileDialog.FileName);
                // cbFile.Text = fileDialog.FileName;
                //cbSourceFolder.Text = System.IO.Path.GetFileName(fileDialog.FileName);
                //cbFile.Text = System.IO.Path.GetFileName(fileDialog.FileName);
                //cbSourceFolder.Text = System.IO.Path.GetDirectoryName(fileDialog.FileName);
          //  } 
            if(folderBrowserDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                //tbListContent1.Text = System.IO.Path.GetDirectoryName(folderBrowserDialog1.SelectedPath.di);

                DirectoryInfo di = new DirectoryInfo(folderBrowserDialog1.SelectedPath);//strBaseDir是起始目录，绝对地址
                DirectoryInfo[] diA = di.GetDirectories();//获得了所有一级子目录
                FileInfo[] fiA = di.GetFiles();//获得了所有起始目录下的文件
                Console.WriteLine(diA[0] + diA.Length.ToString());
                for(int k=0;k<diA.Length;k++)
                {
                    Console.WriteLine(diA[k] + diA.Length.ToString());
                    tbListContent1.AppendText(diA[k].ToString() + "\r\n");
                }
            }
        }

        public ArrayList al = new ArrayList();

        //我把ArrayList当成动态数组用，非常好用

        public void GetAllDirList(string strBaseDir)
        {

            DirectoryInfo di = new DirectoryInfo(strBaseDir);

            DirectoryInfo[] diA = di.GetDirectories();

            for (int i = 0; i < diA.Length; i++)
            {

                al.Add(diA[i].FullName);

                //diA[i].FullName是某个子目录的绝对地址，把它记录在ArrayList中

                GetAllDirList(diA[i].FullName);

                //注意：递归了。逻辑思维正常的人应该能反应过来

            }

        }

        //列出所有值
        // for(int i=0;i<al.Count;i++)
        // {
        //   textBox1.AppendText(al[i].ToString()+" ");
        //  //textBox1
        //}
    }
}
