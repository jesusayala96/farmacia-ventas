using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Farmacias
{
    class Connections
    {
        #region Formas
        Forma_X f1;
        Forma_Consultas f2;
        login l1;
        Ventas V1;
        ConsultaVentas CV1;
        GerenteVentas GV1;

        #endregion

        #region Constructores
        public Connections()
        { }
        public Connections(Forma_X f)
        {
            f1 = f;
        }
        public Connections(Forma_Consultas f)
        {
            f2 = f;
        }
        public Connections(login l)
        {
            l1 = l;
        }
        public Connections(Ventas v)
        {
            V1 = v;
        }
        public Connections(GerenteVentas g)
        { GV1 = g; }
        public Connections(ConsultaVentas c)
        { CV1 = c; }
        #endregion

        #region Variables
        SqlCommand command;
        SqlDataReader leer;
        DataSet dat;
        SqlDataAdapter ada;
        #endregion

        #region Inventarios
        public void insertarInv(string a, string b, string c, string idal)
        {
            //existencias, idalmacen, idproducto, fecha, comentarios         
            Singleton.Instance.OpenDBConnection();

            command=new SqlCommand(string.Format("select existencias from inventario where idproducto={0} and idalmacen={1}", b, idal), Singleton.Instance.GetDBConnection());
            leer = command.ExecuteReader();                       
            if (!leer.Read())
            {
                Singleton.Instance.OpenDBConnection();
                command = new SqlCommand("insert into inventario(existencias, idalmacen, idproducto, fecha, comentarios ) values(@a,@b,@c,@d,@e)", Singleton.Instance.GetDBConnection()); 
                command.Parameters.AddWithValue("a", a);
                command.Parameters.AddWithValue("b", idal/*numero de almacen se recibe como parametro desde el loggin*/);
                command.Parameters.AddWithValue("c", b);
                command.Parameters.AddWithValue("d", DateTime.Now.Date);
                command.Parameters.AddWithValue("e", c);
                command.ExecuteNonQuery();
            }
            else 
            {
                int existe = int.Parse(a) + leer.GetInt32(0);
                
                Singleton.Instance.OpenDBConnection();
                command = new SqlCommand(string.Format("update inventario set existencias=@a where idproducto={0} and idalmacen={1}", b, idal), Singleton.Instance.GetDBConnection());
                command.Parameters.AddWithValue("a", existe.ToString());
                command.ExecuteNonQuery();
                
            }
        }
        public void UpdateInv(string a, string b, string c, string idal)
        {
            Singleton.Instance.OpenDBConnection();
            //existencias, idalmacen, idproducto, fecha, comentarios
            command = new SqlCommand(string.Format("update inventario set existencias=@a, idalmacen=@b, idproducto=@c, fecha=@d,comentarios=@e where idproducto={0} and idalmacen={1}", b, idal), Singleton.Instance.GetDBConnection());
            command.Parameters.AddWithValue("a", a);
            command.Parameters.AddWithValue("b", idal/*numero de almacen se recibe como parametro desde el loggin*/);
            command.Parameters.AddWithValue("c", b);
            command.Parameters.AddWithValue("d", DateTime.Now.Date);
            command.Parameters.AddWithValue("e", c);
            command.ExecuteNonQuery();
            
        }
        public void busquedaEdInv(string num)
        {
            //existencias, idalmacen, idproducto, fecha, comentarios
            Singleton.Instance.OpenDBConnection();
            command = new SqlCommand(string.Format("select existencias, idproducto, comentarios from inventario where inventario.idproducto={0} and inventario.idalmacen={1}", num, 101), Singleton.Instance.GetDBConnection());
            leer = command.ExecuteReader();
            leer.Read();
            f1.tbxEdInvNP.Text = leer.GetInt32(1).ToString();
            f1.tbxEdInvQt.Text = leer.GetInt32(0).ToString();
            f1.tbxEdInvCom.Text = leer.GetString(2);
            
        }
        #endregion

        #region Empleados
        public void insertarEmp(string a, string b, string c, string suc, string d, string e, string f)
        {
            Singleton.Instance.OpenDBConnection();
            //idempleado, nombre, apellidos, idpuesto, idsucursal, estado
            //idusuario, usuario, contraseña
            command = new SqlCommand("insert into empleados(nombre, apellidos, idpuesto, idsucursal, estado) values(@a,@b,@c,@suc,@d)", Singleton.Instance.GetDBConnection());
            command.Parameters.AddWithValue("a", a);
            command.Parameters.AddWithValue("b", b);
            command.Parameters.AddWithValue("c", c);
            command.Parameters.AddWithValue("suc", suc);
            command.Parameters.AddWithValue("d", d);
            command.ExecuteNonQuery();
            command = new SqlCommand("insert into usuarios(usuario, contraseña) values(@e,@f)", Singleton.Instance.GetDBConnection());
            command.Parameters.AddWithValue("e", e);
            command.Parameters.AddWithValue("f", f);
            command.ExecuteNonQuery();
            
        }
        public void UpdateEmp(string a, string b, string c, string suc, string d, string e, string f, string num)
        {
            Singleton.Instance.OpenDBConnection();
            //idempleado, nombre, apellidos, idpuesto, idsucursal, estado
            //idusuario, usuario, contraseña
            command = new SqlCommand(string.Format("update empleados set nombre=@a, apellidos=@b, idpuesto=@c, idsucursal=@suc, estado=@d where empleados.idempleado={0}", num), Singleton.Instance.GetDBConnection());
            command.Parameters.AddWithValue("a", a);
            command.Parameters.AddWithValue("b", b);
            command.Parameters.AddWithValue("c", c);
            command.Parameters.AddWithValue("suc", suc);
            command.Parameters.AddWithValue("d", d);
            command.ExecuteNonQuery();
            command = new SqlCommand(string.Format("update usuarios set usuario=@e,contraseña=@f where idusuario={0}", num), Singleton.Instance.GetDBConnection());
            command.Parameters.AddWithValue("e", e);
            command.Parameters.AddWithValue("f", f);
            command.ExecuteNonQuery();
            
        }
        public void busquedaEdEmp(string num)
        {
            //idempleado, nombre, apellidos, idpuesto, idsucursal, estado
            Singleton.Instance.OpenDBConnection();
            command = new SqlCommand(string.Format("select nombre, apellidos, idpuesto,estado from empleados where idempleado={0}", num), Singleton.Instance.GetDBConnection());
            leer = command.ExecuteReader();
            leer.Read();
            f1.tbxEdENom.Text = leer.GetString(0);
            f1.tbxEdEApe.Text = leer.GetString(1);
            f1.cbxEdEPues.Text = leer.GetInt32(2).ToString();
            if (!leer.GetBoolean(3))
                f1.cbxEdEStat.Text = "0 : Inactivo";
            else
                f1.cbxEdEStat.Text = "1 : Activo";
            leer.Close();
            //idusuario, usuario, contraseña
            command = new SqlCommand(string.Format("select usuario, contraseña from usuarios where idusuario={0}", num), Singleton.Instance.GetDBConnection());
            leer = command.ExecuteReader();
            leer.Read();
            f1.tbxEdEUsua.Text = leer.GetString(0);
            f1.tbxEdECont.Text = leer.GetString(1);
            
        }
        #endregion

        #region Proveedores
        public void insertarProv(string nombre, string respon, string direc, string tel, string rfc, string corr)
        {
            Singleton.Instance.OpenDBConnection();

            command = new SqlCommand("insert into proveedor(Nombre, Responsable, Direccion, RFC, Telefono, Correo) values(@a,@b,@c,@d,@e,@f)", Singleton.Instance.GetDBConnection());
            command.Parameters.AddWithValue("a", nombre);
            command.Parameters.AddWithValue("b", respon);
            command.Parameters.AddWithValue("c", direc);
            command.Parameters.AddWithValue("d", tel);
            command.Parameters.AddWithValue("e", rfc);
            command.Parameters.AddWithValue("f", corr);
            command.ExecuteNonQuery();
            //command.ExecuteNonQuery();
            //idproveedor, Nombre, Responsable, Direccion, RFC, Telefono, Correo            
            
        }
        public void UpdateProv(string nombre, string respon, string direc, string tel, string rfc, string corr, string numprov)
        {
            Singleton.Instance.OpenDBConnection();

            command = new SqlCommand(string.Format("update proveedor set Nombre=@a, Responsable=@b, Direccion=@c, RFC=@d, Telefono=@e, Correo=@f where proveedor.idproveedor={0}", numprov), Singleton.Instance.GetDBConnection());
            command.Parameters.AddWithValue("a", nombre);
            command.Parameters.AddWithValue("b", respon);
            command.Parameters.AddWithValue("c", direc);
            command.Parameters.AddWithValue("d", tel);
            command.Parameters.AddWithValue("e", rfc);
            command.Parameters.AddWithValue("f", corr);
            command.ExecuteNonQuery();
            //command.ExecuteNonQuery();
            //idproveedor, Nombre, Responsable, Direccion, RFC, Telefono, Correo            
            
        }
        public void busquedaEdProv(string numprov)
        {
            Singleton.Instance.OpenDBConnection();
            command = new SqlCommand(string.Format("select Nombre, Responsable, Direccion, RFC, Telefono, Correo from proveedor where proveedor.idproveedor={0}", numprov), Singleton.Instance.GetDBConnection());
            leer = command.ExecuteReader();
            leer.Read();
            f1.tbxEdPNom.Text = leer.GetString(0);
            f1.tbxEdPResp.Text = leer.GetString(1);
            f1.tbxEdPDir.Text = leer.GetString(2);
            f1.tbxEdPRFC.Text = leer.GetString(3);
            f1.tbxEdPTel.Text = leer.GetString(4);
            f1.tbxEdPCorr.Text = leer.GetString(5);
            
            //idproveedor, Nombre, Responsable, Direccion, RFC, Telefono, Correo 

        }
        #endregion

        #region Productos
        public void insertarProd(string a, string b, string c, string d, string e, string f)
        {
            Singleton.Instance.OpenDBConnection();
            //idproducto, producto, Activo, idvia, reqReceta, Precio, idproveedor            
            command = new SqlCommand("insert into productos(producto, Activo, idvia, reqReceta, Precio, idproveedor) values(@a,@b,@c,@d,@e,@f)", Singleton.Instance.GetDBConnection());
            command.Parameters.AddWithValue("a", a);
            command.Parameters.AddWithValue("b", b);
            command.Parameters.AddWithValue("c", c);
            command.Parameters.AddWithValue("d", d);
            command.Parameters.AddWithValue("e", e);
            command.Parameters.AddWithValue("f", f);
            command.ExecuteNonQuery();
            
        }
        public void UpdateProd(string a, string b, string c, string d, string e, string f, string num)
        {
            Singleton.Instance.OpenDBConnection();
            //idproducto, producto, Activo, idvia, reqReceta, Precio, idproveedor            
            command = new SqlCommand(string.Format("update productos set producto=@a, activo=@b, idvia=@c, reqreceta=@d, precio=@e, idproveedor=@f where productos.idproducto={0}", num), Singleton.Instance.GetDBConnection());
            command.Parameters.AddWithValue("a", a);
            command.Parameters.AddWithValue("b", b);
            command.Parameters.AddWithValue("c", c);
            command.Parameters.AddWithValue("d", d);
            command.Parameters.AddWithValue("e", e);
            command.Parameters.AddWithValue("f", f);
            command.ExecuteNonQuery();
            
        }
        public void busquedaEdProd(string num)
        {
            Singleton.Instance.OpenDBConnection();
            command = new SqlCommand(string.Format("select producto, Activo, idvia, reqReceta, Precio, idproveedor from productos where productos.idproducto={0}", num), Singleton.Instance.GetDBConnection());
            leer = command.ExecuteReader();
            leer.Read();
            f1.tbxEdPdNom.Text = leer.GetString(0);
            f1.tbxEdPdAct.Text = leer.GetString(1);
            f1.cbxEdPdVia.Text = leer.GetInt32(2).ToString();
            if (!leer.GetBoolean(3))
                f1.cbxEdPdRec.Text = "0 : No";
            else
                f1.cbxEdPdRec.Text = "1 : Si";
            f1.tbxEdPdPrec.Text = leer.GetInt32(4).ToString();
            f1.tbxEdPdNumProv.Text = leer.GetInt32(5).ToString();
            
            //idproducto, producto, Activo, idvia, reqReceta, Precio, idproveedor

        }
        #endregion

        #region consultas

        public void ConsulEm(string par, string abusq,string idsucur)
        {
            if (abusq == "Número")
            {
                Singleton.Instance.OpenDBConnection();
                ada = new SqlDataAdapter(string.Format("select * from Empleados where idempleado={0}", par), Singleton.Instance.GetDBConnection());
                dat = new DataSet();
                ada.Fill(dat, "empleados");
                f2.dataGridEmp.DataSource = dat;
                f2.dataGridEmp.DataMember = "empleados";
                
            }
            else if (abusq == "Nombre")
            {
                //select apellidos from Empleados where nombre='david'
                Singleton.Instance.OpenDBConnection();
                ada = new SqlDataAdapter(string.Format("select * from Empleados where nombre='{0}'", par), Singleton.Instance.GetDBConnection());
                dat = new DataSet();
                ada.Fill(dat, "empleados");
                f2.dataGridEmp.DataSource = dat;
                f2.dataGridEmp.DataMember = "empleados";
                
            }
            else 
            {
                Singleton.Instance.OpenDBConnection();
                ada = new SqlDataAdapter(string.Format("select * from Empleados where idsucursal='{0}'", idsucur), Singleton.Instance.GetDBConnection());
                dat = new DataSet();
                ada.Fill(dat, "empleados");
                f2.dataGridEmp.DataSource = dat;
                f2.dataGridEmp.DataMember = "empleados";
                
            }

        }
        public void ConsulInv(string par, string abusq, string alm)
        {
            if (abusq == "Número")
            {
                Singleton.Instance.OpenDBConnection();
                ada = new SqlDataAdapter(string.Format("select productos.producto,productos.Activo,inventario.existencias,inventario.idproducto "
                + "from productos,inventario where inventario.idproducto=productos.idproducto and productos.idproducto={0} and inventario.idalmacen={1}", par, alm), Singleton.Instance.GetDBConnection());
                dat = new DataSet();
                ada.Fill(dat, "inventario");
                f2.dataGridinv.DataSource = dat;
                f2.dataGridinv.DataMember = "inventario";
                
            }
            else if (abusq == "Nombre")
            {
                Singleton.Instance.OpenDBConnection();
                ada = new SqlDataAdapter(string.Format("select productos.producto,productos.Activo,inventario.existencias,inventario.idproducto " +
                    "from productos,inventario where inventario.idproducto=productos.idproducto and productos.producto='{0}'", par), Singleton.Instance.GetDBConnection());
                dat = new DataSet();
                ada.Fill(dat, "inventario");
                f2.dataGridinv.DataSource = dat;
                f2.dataGridinv.DataMember = "inventario";
                
            }
            else
            {
                Singleton.Instance.OpenDBConnection();
                ada = new SqlDataAdapter(string.Format("select productos.producto,productos.Activo,inventario.existencias,inventario.idproducto " +
                    "from productos,inventario where inventario.idproducto=productos.idproducto and inventario.idalmacen='{0}'", alm), Singleton.Instance.GetDBConnection());
                dat = new DataSet();
                ada.Fill(dat, "inventario");
                f2.dataGridinv.DataSource = dat;
                f2.dataGridinv.DataMember = "inventario";
                
            }
        }


        public void ConsulPd(string par, string abusq)
        {
            if (abusq == "Número")
            {
                Singleton.Instance.OpenDBConnection();
                ada = new SqlDataAdapter(string.Format("select * from productos where idproducto={0}", par), Singleton.Instance.GetDBConnection());
                dat = new DataSet();
                ada.Fill(dat, "productos");
                f2.dataGridpd.DataSource = dat;
                f2.dataGridpd.DataMember = "productos";
                
            }
            else
            {
                //select apellidos from Empleados where nombre='david'
                //idproducto, producto, Activo, idvia, reqReceta, Precio, idproveedor
                Singleton.Instance.OpenDBConnection();
                ada = new SqlDataAdapter(string.Format("select * from productos where producto='{0}'", par), Singleton.Instance.GetDBConnection());
                dat = new DataSet();
                ada.Fill(dat, "productos");
                f2.dataGridpd.DataSource = dat;
                f2.dataGridpd.DataMember = "productos";
                
            }
        }
        public void ConsulPv(string par, string abusq)
        {
            if (abusq == "Número")
            {
                Singleton.Instance.OpenDBConnection();
                ada = new SqlDataAdapter(string.Format("select * from proveedor where idproveedor={0}", par), Singleton.Instance.GetDBConnection());
                dat = new DataSet();
                ada.Fill(dat, "proveedor");
                f2.dataGridpv.DataSource = dat;
                f2.dataGridpv.DataMember = "proveedor";
                
            }
            else
            {
                //select apellidos from Empleados where nombre='david'
                //idproveedor, Nombre, Responsable, Direccion, RFC, Telefono, Correo
                Singleton.Instance.OpenDBConnection();
                ada = new SqlDataAdapter(string.Format("select * from proveedor where nombre='{0}'", par), Singleton.Instance.GetDBConnection());
                dat = new DataSet();
                ada.Fill(dat, "proveedor");
                f2.dataGridpv.DataSource = dat;
                f2.dataGridpv.DataMember = "proveedor";
                
            }
        }

        #endregion

        public void cbx()
        {
            Singleton.Instance.OpenDBConnection();

            command = new SqlCommand("select * from viaAdministracion", Singleton.Instance.GetDBConnection());
            leer = command.ExecuteReader();
            f1.cbxAddPdVia.Items.Clear();
            f1.cbxAddPdRec.Items.Clear();
            f1.cbxEdPdVia.Items.Clear();
            f1.cbxEdPdRec.Items.Clear();
            f1.cbxEdEPues.Items.Clear();
            f1.cbxAddEPues.Items.Clear();
            f1.cbxAddEStat.Items.Clear();
            f1.cbxEdEStat.Items.Clear();
            //cbxEdEPues
            f1.cbxAddEStat.Items.Clear();
            while (leer.Read())
            {
                f1.cbxAddPdVia.Items.Add(leer.GetInt32(0) + " : " + leer.GetString(1));
                f1.cbxEdPdVia.Items.Add(leer.GetInt32(0) + " : " + leer.GetString(1));
            }
            f1.cbxAddPdRec.Items.Add("1 : Si");
            f1.cbxAddPdRec.Items.Add("0 : No");
            f1.cbxEdPdRec.Items.Add("1 : Si");
            f1.cbxEdPdRec.Items.Add("0 : No");
            f1.cbxAddEStat.Items.Add("1 : Activo");
            f1.cbxAddEStat.Items.Add("0 : Inactivo");
            f1.cbxEdEStat.Items.Add("1 : Activo");
            f1.cbxEdEStat.Items.Add("0 : Inactivo");
            leer.Close();
            command = new SqlCommand("select * from puestos", Singleton.Instance.GetDBConnection());
            leer = command.ExecuteReader();
            while (leer.Read())
            {
                f1.cbxAddEPues.Items.Add(leer.GetInt32(0) + " : " + leer.GetString(1));
                f1.cbxEdEPues.Items.Add(leer.GetInt32(0) + " : " + leer.GetString(1));
            }
           
        }
        public void cbx1(string ids,string idem)
        {

            GV1.cbVendedor.Items.Clear();
            Singleton.Instance.OpenDBConnection();
            command = new SqlCommand(string.Format("select empleados.idempleado from empleados,sucursal where empleados.idsucursal=sucursal.idsucursal and sucursal.idsucursal={0} and empleados.idempleado <>{1}", ids,idem), Singleton.Instance.GetDBConnection());
            leer = command.ExecuteReader();
            while (leer.Read())
            {
                GV1.cbVendedor.Items.Add(leer.GetInt32(0));
            }
          
        }
        #region login
        public string Login(string user, string pass)
        {
            string puesto;
            Singleton.Instance.OpenDBConnection();
            command = new SqlCommand(string.Format("select puestos.idpuesto,usuarios.contraseña,empleados.nombre,empleados.apellidos,empleados.idsucursal,almacen.idalmacen, sucursal.nombre, empleados.idempleado "
                +"from empleados,puestos,usuarios,almacen ,sucursal where empleados.idpuesto=puestos.idpuesto and usuarios.idusuario=empleados.idempleado and almacen.idsucursal=empleados.idsucursal "
                +"and sucursal.idsucursal=empleados.idsucursal and usuarios.usuario='{0}'", user), Singleton.Instance.GetDBConnection());
            leer = command.ExecuteReader();
            if (leer.Read())
            {
                if (pass == leer.GetString(1))
                {
                    puesto = leer.GetInt32(0).ToString();
                    l1.nombre = leer.GetString(2) +" "+ leer.GetString(3);
                    l1.idsucursal = leer.GetInt32(4).ToString();
                    l1.idalmacen = leer.GetInt32(5).ToString();
                    l1.nombrefar = leer.GetString(6);
                    l1.idempleado = leer.GetInt32(7).ToString();
                    
                    return puesto;
                }
                else
                {
                    
                    return "Contraseña inconrrecta!";

                }
            }
            else
            {
                
                return "Usuario no existe!";
            }
        }
        #endregion

        #region Ventas
        public void ActualizarTxt(string id, string almacen)
        {
            Singleton.Instance.OpenDBConnection();
            SqlCommand QueryP = new SqlCommand(string.Format("select productos.reqReceta, productos.producto, productos.Precio from productos,almacen,inventario where almacen.idalmacen=inventario.idalmacen "
            +"and inventario.idproducto=productos.idproducto and inventario.idproducto={0} and almacen.idalmacen={1}", id, almacen), Singleton.Instance.GetDBConnection());
            SqlDataReader reader = QueryP.ExecuteReader();

            if (reader.Read() & !reader.GetBoolean(0))//Si lo encuentra actualiza
            {
                V1.txtNP.Text = reader.GetSqlValue(1).ToString();
                V1.lblP.Text = reader.GetSqlValue(2).ToString();
                V1.txtCP.Focus();
                
                
            }
            else
            {
                //aki que se abra una forma en donde debera capturar los datos de la receta no aki no :p con el message box basta
                V1.txtNP.Text = reader.GetSqlValue(1).ToString();
                V1.lblP.Text = reader.GetSqlValue(2).ToString();
                V1.txtCP.Focus();
                MessageBox.Show("Vendedor no olvides capturar la receta");
            }
            
        }
        public int NumeroFactura()
        {
            int n;
            Singleton.Instance.OpenDBConnection();
            SqlCommand NuF = new SqlCommand("SELECT COUNT(IDFactura) AS Numero FROM Factura", Singleton.Instance.GetDBConnection());//Cuenta las facturas existentes
            SqlDataReader read;
            read = NuF.ExecuteReader();
            while (read.Read())
            {
                n= read.GetInt32(0);
                
                return n+1;//Si no hay facturas da 0, asi que seria la factura 1
            }
            
            return 0;
        }
        public int NumeroReceta()
        {
            int n;
            Singleton.Instance.OpenDBConnection();
            SqlCommand NuF = new SqlCommand("SELECT COUNT(idreceta) AS Numero FROM receta", Singleton.Instance.GetDBConnection());//Cuenta las facturas existentes
            SqlDataReader read;
            read = NuF.ExecuteReader();
            while (read.Read())
            {
                n = read.GetInt32(0);
                
                return n + 1;//Si no hay facturas da 0, asi que seria la factura 1
            }
            
            return 0;
        }
        public void AgregarProducto(int NF, string id, string np, string cp, string pp)
        {
            try
            {
                int ID = int.Parse(id), C = int.Parse(cp), P = int.Parse(pp);
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(V1.dgVenta);//Se crea una fila con los datos del producto (factura,numero,precio...)
                row.Cells[0].Value = NF;
                row.Cells[1].Value = ID;
                row.Cells[2].Value = np;
                row.Cells[3].Value = C;
                row.Cells[4].Value = P;
                V1.dgVenta.Rows.Add(row);// Agregar a grid
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe introducir una cantidad!");
            }
            finally
            {
                V1.txtIP.Clear(); V1.txtNP.Clear(); V1.txtCP.Clear(); V1.txtIP.Focus();
            }

        }
        public void GuardarDetalleFactura(string a)
        {
            for (int i = 0; i < V1.dgVenta.Rows.Count; i++)//Recorrido por el datagrid, inserta una fila a la vez
            {
                SqlCommand StrQuery = new SqlCommand("INSERT INTO detallefactura (idfactura,idproducto,cantidad,precio) VALUES ('" + V1.dgVenta.Rows[i].Cells[0].Value + "',' " + V1.dgVenta.Rows[i].Cells[1].Value + "', '" + V1.dgVenta.Rows[i].Cells[3].Value + "', '" + V1.dgVenta.Rows[i].Cells[4].Value + "')", Singleton.Instance.GetDBConnection());
                // try
                // {
                Singleton.Instance.OpenDBConnection();
                    StrQuery.ExecuteNonQuery();
                

                    //Inventario
                    SqlCommand ModificarExistencia = new SqlCommand("UPDATE inventario SET existencias=existencias-@Cantidad WHERE idproducto=@P and idalmacen=@A", Singleton.Instance.GetDBConnection());
                    ModificarExistencia.Parameters.AddWithValue("@Cantidad", V1.dgVenta.Rows[i].Cells[3].Value);
                    ModificarExistencia.Parameters.AddWithValue("@P", V1.dgVenta.Rows[i].Cells[1].Value);
                    ModificarExistencia.Parameters.AddWithValue("@A", a);
                	Singleton.Instance.OpenDBConnection();
                    ModificarExistencia.ExecuteNonQuery();
                
            }
        }
        public void GuardarFactura(int nf, string f, int t, string id)
        {
            Singleton.Instance.OpenDBConnection();
            //numF no se ocupa, fecha.Text, total, ide
            SqlCommand AgregarF = new SqlCommand("INSERT INTO factura (fecha, total, idempleado) VALUES (@f,@t,@e)", Singleton.Instance.GetDBConnection());
            AgregarF.Parameters.AddWithValue("@f", f);
            AgregarF.Parameters.AddWithValue("@t", t);
            AgregarF.Parameters.AddWithValue("@e", int.Parse(id));
            AgregarF.ExecuteNonQuery();
            
        }
        public void Total()
        {
            int total = 0;
            foreach (DataGridViewRow Celda in V1.dgVenta.Rows)
            {
                total += (int.Parse(Celda.Cells[3].Value.ToString()))*int.Parse((Celda.Cells[4].Value.ToString()));
            }
            V1.total = total;
        }
        #endregion

        #region ConsultaEnVentas
        public void ConsulPro(string par, string abusq)
        {
        if (abusq == "Número")
            {
                Singleton.Instance.OpenDBConnection();
                ada = new SqlDataAdapter(string.Format("select * from productos where idproducto={0}", par), Singleton.Instance.GetDBConnection());
                dat = new DataSet();
                ada.Fill(dat, "productos");
                CV1.dataGridpd.DataSource = dat;
                CV1.dataGridpd.DataMember = "productos";
                
            }
            else
            {
                //select apellidos from Empleados where nombre='david'
                //idproducto, producto, Activo, idvia, reqReceta, Precio, idproveedor
                Singleton.Instance.OpenDBConnection();
                ada = new SqlDataAdapter(string.Format("select * from productos where producto='{0}'", par), Singleton.Instance.GetDBConnection());
                dat = new DataSet();
                ada.Fill(dat, "productos");
                CV1.dataGridpd.DataSource = dat;
                CV1.dataGridpd.DataMember = "productos";
                
            }
        }
        #endregion
        #region VentasGerente
        public void VentasTotales(int sucursal)
        {
            Singleton.Instance.OpenDBConnection();
            ada = new SqlDataAdapter(string.Format("select factura.idfactura, factura.fecha, factura.total, factura.idempleado from factura,empleados,sucursal where empleados.idempleado=factura.idempleado and empleados.idsucursal=sucursal.idsucursal and sucursal.idsucursal={0}", sucursal), Singleton.Instance.GetDBConnection());
            dat = new DataSet();
            ada.Fill(dat, "Ventas Totales");
            GV1.datagridVT.DataSource = dat;
            GV1.datagridVT.DataMember = "Ventas Totales";
            SqlCommand sql = new SqlCommand(string.Format("SELECT SUM(total) as 'Totales' from factura,empleados,sucursal where empleados.idempleado=factura.idempleado and empleados.idsucursal=sucursal.idsucursal and sucursal.idsucursal={0}",sucursal), Singleton.Instance.GetDBConnection());
            GV1.lblVT.Text = sql.ExecuteScalar().ToString();
            
        }
        public void VentasVendedor(int sucursal, int vendedor)
        {
            Singleton.Instance.OpenDBConnection();
            ada = new SqlDataAdapter(string.Format("Select factura.idfactura, factura.fecha, factura.total, factura.idempleado from factura,empleados,sucursal where empleados.idempleado=factura.idempleado and empleados.idsucursal=sucursal.idsucursal and sucursal.idsucursal={0} and empleados.idempleado={1}", sucursal,vendedor), Singleton.Instance.GetDBConnection());
            dat = new DataSet();
            ada.Fill(dat, "Ventas Vendedor");
            GV1.datagridVV.DataSource = dat;
            GV1.datagridVV.DataMember = "Ventas Vendedor";
            SqlCommand sql = new SqlCommand(string.Format("SELECT SUM(total) as 'Totales' from factura,empleados,sucursal "+
"where empleados.idempleado=factura.idempleado and empleados.idsucursal=sucursal.idsucursal and empleados.idempleado={0}", vendedor), Singleton.Instance.GetDBConnection());
            GV1.lblVV.Text = sql.ExecuteScalar().ToString();
            
        }
        public void LlenarEmpleado(int sucursal)
        {
            SqlCommand cmd = new SqlCommand(string.Format("select empleados.idempleado, empleados.nombre from empleados, sucursal where empleados.idsucursal=sucursal.idsucursal and sucursal.idsucursal={0}", sucursal), Singleton.Instance.GetDBConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GV1.cbVendedor.DataSource = dt;
            GV1.cbVendedor.DisplayMember = "idempelado";
            GV1.cbVendedor.ValueMember = "nombre";
        }
        public void Meses()
        {
            GV1.cbMes.Items.Clear();
            GV1.cbMes.Items.Add("1");
            GV1.cbMes.Items.Add("2");
            GV1.cbMes.Items.Add("3");
            GV1.cbMes.Items.Add("4");
            GV1.cbMes.Items.Add("5");
            GV1.cbMes.Items.Add("6");
            GV1.cbMes.Items.Add("7");
            GV1.cbMes.Items.Add("8");
            GV1.cbMes.Items.Add("9");
            GV1.cbMes.Items.Add("10");
            GV1.cbMes.Items.Add("11");
            GV1.cbMes.Items.Add("12");
        }
  /*     public void VentasDia(int sucursal, string dia) 
        {
            connect.Open();
            ada = new SqlDataAdapter(string.Format("select factura.idfactura, factura.fecha, factura.total, factura.idempleado from factura, empleados, sucursal where factura.fecha={0} and empleados.idempleado=factura.idempleado and empleados.idsucursal=sucursal.idsucursal and sucursal.idsucursal={1}",dia,sucursal), connect);
            dat = new DataSet();
            ada.Fill(dat, "Ventas Dia");
            GV1.dataFecha.DataSource = dat;
            GV1.dataFecha.DataMember = "Ventas Dia";
            connect.Close();

            int total = 0;
            foreach (DataGridViewRow Celda in GV1.datagridVT.Rows)
            {
                total += int.Parse(Celda.Cells[2].Value.ToString());
            }
            GV1.lblVT.Text = total.ToString();
        }
        public void VentasMes(int sucursal, int mes)
        {
            connect.Open();
            ada = new SqlDataAdapter(string.Format("select factura.idfactura, factura.fecha, factura.total, factura.idempleado from factura, empleados, sucursal where month(factura.fecha)={0} and empleados.idempleado=factura.idempleado and empleados.idsucursal=sucursal.idsucursal and sucursal.idsucursal={1}", mes, sucursal), connect);
            dat = new DataSet();
            ada.Fill(dat, "Ventas Mes");
            GV1.dataFecha.DataSource = dat;
            GV1.dataFecha.DataMember = "Ventas Mes";
            connect.Close();

            int total = 0;
            foreach (DataGridViewRow Celda in GV1.datagridVT.Rows)
            {
                total += int.Parse(Celda.Cells[2].Value.ToString());
            }
            GV1.lblVT.Text = total.ToString();
        }*/
        #endregion

        public void receta(string a, string b, string c)
        {
            Singleton.Instance.OpenDBConnection();
            SqlCommand AgregarF = new SqlCommand("INSERT INTO receta (nombreDoctor, Cedula,idfactura) VALUES (@a,@b,@c)", Singleton.Instance.GetDBConnection());
            AgregarF.Parameters.AddWithValue("@a", a);
            AgregarF.Parameters.AddWithValue("@b", b);
            AgregarF.Parameters.AddWithValue("@c",c);
            AgregarF.ExecuteNonQuery();
            
        }
    }
}