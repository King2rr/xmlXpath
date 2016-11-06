using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Xml.Xsl;


namespace UC.XMLEducator
{
    public partial class Form1 : Form
    {
        private string tempXMLFilePath = Path.GetTempFileName();
        private bool IsXMLValidated;
        private XmlDocument xDoc;

        //public string originalXmlFile;
        //private string debugString;
        //private string previousXmlFile;
        //private System.Windows.Forms.WebBrowser webBrowser;


        public Form1()
        {
            InitializeComponent();
            IsXMLValidated = false;
        }

        #region Event Handlers
        private void rtbXPathXML_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImportXML_Click(object sender, EventArgs e)
        {
            openXMLFileDialog.Title = Util.GetTitle();
            openXMLFileDialog.InitialDirectory = Util.ReadFromRegistry("LastXmlDir");
            openXMLFileDialog.ShowDialog();
        }

        private void openXMLFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            LoadXMLFile(fileName: openXMLFileDialog.FileName);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                xDoc = new XmlDocument();
                xDoc.LoadXml(rtbXMLContent.Text);
                IsXMLValidated = true;
                ChangeToStateValidated();
            }
            catch
            {
                MessageBox.Show("Please input a valid XML");
            }
        }

        private void wbrXML_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void txtXMLFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                CommitXPath();
            }
            catch
            {
                MessageBox.Show("Invalid XPath");
                cmbXPath.Text = "/";
            }
        }
        #endregion

        #region Custom Functions

        private void testInitialization()
        {
            txtXMLFilePath.Text = @"C:\Users\king2rr\Desktop\students.xml";
            btnImportXML_Click(null, null);
            btnValidate_Click(null, null);
            cmbXPath.Text = @"/students";
        }
        private void CommitXPath()
        {
            XPathDocument doc = new XPathDocument(tempXMLFilePath + "temp.xml");
            XPathNavigator nav = doc.CreateNavigator();

            string result = "";
            string resultType = "";

            if (nav.Evaluate(cmbXPath.Text).GetType().ToString() == "MS.Internal.Xml.XPath.XPathSelectionIterator")
            {
                XPathNodeIterator iterator = (XPathNodeIterator)nav.Evaluate(cmbXPath.Text);

                while (iterator.MoveNext())
                {
                    resultType = "";
                    resultType = iterator.Current.InnerXml;
                    //switch (cmbXPath.SelectedItem.ToString())
                    //{
                    //    case "InnerXml":
                    //        resultType = iterator.Current.InnerXml;
                    //        break;
                    //    case "OuterXml":
                    //        resultType = iterator.Current.OuterXml;
                    //        break;
                    //    case "Value":
                    //        resultType = iterator.Current.Value;
                    //        break;
                    //}

                    result += string.Format("{0}\r\n", resultType);
                }
            }
            else
            {
                result = string.Format("{0}\r\n", nav.Evaluate(cmbXPath.Text));
            }

            if (resultType == "Value")
            {
                result = string.Format("<pre>\r\n{0}</pre>", result);
            }
            else
            {
                result = string.Format("<xml>\r\n{0}</xml>", result);
            }

            rtbQueryResults.Text = result;
        }
        private void DisplayNodes(XmlNodeList nodes)
        {
            StringBuilder sbXMLQueryResult = new StringBuilder();
            foreach (XmlNode itemNode in nodes)
            {
                XmlNode titleNode = itemNode.SelectSingleNode("title");
                XmlNode dateNode = itemNode.SelectSingleNode("pubDate");
                if ((titleNode != null) && (dateNode != null))
                    Console.WriteLine(dateNode.InnerText + ": " + titleNode.InnerText);
            }

            rtbXMLContent.Text = nodes.ToString();
        }

        private void LoadXMLFile(string fileName)
        {
            txtXMLFilePath.Text = fileName;
            string dir = fileName.Substring(0, fileName.LastIndexOf("\\"));
            Util.SaveToRegistry("LastXsltDir", dir);
            LoadFile(fileName);
        }

        public void LoadFile(string fileName)
        {
            rtbXMLContent.Text = File.ReadAllText(fileName);
        }

        private void ChangeToStateValidated()
        {
            if (!IsXMLValidated)
                return;
            rtbXMLContent.Visible = false;
            wbrXML.Visible = true;
            OpenXMLInBrowser();
        }

        private void OpenXMLInBrowser()
        {
            saveContentToFile(tempXMLFilePath + "temp.xml", rtbXMLContent.Text);
            wbrXML.Url = new Uri(tempXMLFilePath + "temp.xml");
        }
        private void saveContentToFile(string fileName, string content)
        {
            File.WriteAllText(fileName, content);
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            testInitialization();
        }
    }
}
