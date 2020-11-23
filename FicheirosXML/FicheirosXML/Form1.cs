using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FicheirosXML
{
    public partial class Form1 : Form
    {
        private const string path = "D:\\Kalleby\\Documents\\Programing\\C#\\Escola\\FicheirosXML\\FicheirosXML\\XMLFile1.xml";
        public Form1()
        {
            InitializeComponent();
        }

        public XmlElement criarSocio(XmlDocument file, String nome, String numero)
        {

            XmlElement XMLsocio = file.CreateElement("socio");
            XmlAttribute XMLnome = file.CreateAttribute("nome");
            XmlAttribute XMLnumero = file.CreateAttribute("numero");

            XMLsocio.Attributes.Append(XMLnome);
            XMLsocio.Attributes.Append(XMLnumero);

            XMLnome.InnerText = nome;
            XMLnumero.InnerText = numero;

            return XMLsocio;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Cria uma instancia  do documento XML
            XmlDocument file = new XmlDocument();

            // Carrega o arquivo XML
            file.Load(path);

            // Cria um novo socio
            String nome = this.txtNome.Text;
            String numero = this.txtNumero.Text;
            XmlElement socio = criarSocio(file, nome, numero);

            // Adiciona o socio ao ficheiro
            file.DocumentElement.AppendChild(socio);
            file.Save(path);
        }
    }
}
