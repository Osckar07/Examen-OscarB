using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregando el namespace necesario
using System.ComponentModel;

namespace Planilla
{
    public class planilla : INotifyPropertyChanged
    {
        // Variables miembro
        private string nombre_del_Empleado;
        private string identidad;
        private int horasTrabajadas;
        private float pagoHoraNormalTrabajo;
        private int horasExtrasTrabajadas;
        private float pagoHoraTrabajoExtra;

        public planilla()
        {
            Nombre_del_Empleado = "Oscar Benites";
            Identidad = "1007-1998-00788";
            HorasTrabajadas = 8;
            PagoHoraNormalTrabajo = 32000;
            HorasExtrasTrabajadas = 5;
            PagoHoraTrabajoExtra = 1200;

        }

        public string Nombre_del_Empleado { get => nombre_del_Empleado; set => nombre_del_Empleado = value; }
        public string Identidad { get => identidad; set => identidad = value; }
        public int HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
        public float PagoHoraNormalTrabajo { get => pagoHoraNormalTrabajo; set => pagoHoraNormalTrabajo = value; }
        public int HorasExtrasTrabajadas { get => horasExtrasTrabajadas; set => horasExtrasTrabajadas = value; }
        public float PagoHoraTrabajoExtra { get => pagoHoraTrabajoExtra; set => pagoHoraTrabajoExtra = value; }
    }

