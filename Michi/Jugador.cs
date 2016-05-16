using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;

using System.Xml.Linq;
//using System.Xml.Linq.X;
using System.Xml.XPath;
using System.IO;

namespace Michi
{
    public class Jugador
    {
        private string FileName = "Data.xml";
        private string GroupNode = "Jugadores";
        private string Node = "Jugador";

        private string _nombre;
        private string _usuario;
        private string _clave;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        public Jugador()
        {
            this.Nombre = "";
            this.Usuario = "";
            this.Clave = "";
        }

        public bool insertar()
        {
            XDocument xdoc = GetDataXml();

            XElement obj = xdoc.Element(GroupNode).Elements(Node).
                Where(X => X.Element("Usuario").Value == this.Usuario).SingleOrDefault();

            if (obj == null)
            {
                xdoc.Element(GroupNode).Add(
                new XElement(Node,
                    new XElement("Nombre", this.Nombre),
                    new XElement("Usuario", this.Usuario),
                    new XElement("Clave", this.Clave)
                    )
                );

                SetDataXml(xdoc);

                return true;
            }
            else
                return false;
        }

        public bool obtener()
        {
            XDocument xdoc = GetDataXml();

            XElement obj = xdoc.Element(GroupNode).Elements(Node).
                Where(X => X.Element("Usuario").Value == this.Usuario & X.Element("Clave").Value == this.Clave).SingleOrDefault();

            if (obj != null)
            {
                this.Nombre = obj.Element("Nombre").Value;
                this.Usuario = obj.Element("Usuario").Value;
                this.Clave = obj.Element("Clave").Value;

                return true;
            }
            else
                return false;
        }

        public void actualizar()
        {

            XDocument xdoc = GetDataXml();

            XElement obj = xdoc.Element(GroupNode).Elements(Node).
                Where(X => X.Element("Usuario").Value == this.Usuario).SingleOrDefault();

            obj.SetElementValue("Nombre", this.Nombre);
            obj.SetElementValue("Clave", this.Clave);

            SetDataXml(xdoc);

            //XDocument xdoc = DataXml();

            //List<XElement> l = xdoc.Element(GroupNode).Elements(Node).
            //    Where(X => X.Element("Usuario").Value == this.Usuario).ToList();

            //foreach (XElement obj in l)
            //{
            //    obj.SetElementValue("Nombre", this.Nombre);
            //    obj.SetElementValue("Clave", this.Clave);
            //}

            //Salvar(xdoc);
        }

        public void eliminar(string usuario)
        {
            XDocument xdoc = GetDataXml();

            xdoc.Element(GroupNode).Elements(Node).Where(X => X.Element("Usuario").Value == usuario).Remove();

            SetDataXml(xdoc);
        }

        private XDocument GetDataXml()
        {
            string PathData = Path.Combine(Environment.CurrentDirectory, FileName);

            XDocument xdoc;

            if (File.Exists(PathData))
            {
                xdoc = XDocument.Load(PathData);
            }
            else
            {
                xdoc = new XDocument(new XElement(GroupNode));
            }
            return xdoc;
        }
        
        private void SetDataXml(XDocument xdoc)
        {
            xdoc.Save(Path.Combine(Environment.CurrentDirectory, FileName));
        }

    }
}
