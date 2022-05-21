using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesBar
{
    public class Empleado
    {
        private int dni;
        private string nombre;
        private string contrasena;
        EPermisos permisos;

        public Empleado()
        {

        }

        public Empleado(int dni, string nombre, string contrasena, EPermisos rol)
        {
            this.dni = dni;
            this.contrasena = contrasena;
            this.nombre = nombre;
            this.permisos = rol;
        }

        public int Dni
        {
            get { return dni; }
        }
        public string Nombre
        {
            get { return nombre; }
        }

        public EPermisos Permisos
        {
            get { return permisos; }
        }

        public bool VerificarContrasena(string contrasenaIngresada)
        {
            return (!string.IsNullOrEmpty(contrasenaIngresada) && contrasenaIngresada.Trim() == contrasena.Trim());
        }

        public static void CerrarCuenta (Cuenta cuentaCliente)
        {
            
        }


    }
    
}
