﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string nombre;
        private string marca;
        private string descripcion;
        private float precio;
        private ETipo tipo;
        //private fechaDeVencimiento
        private int stock;
        private int id;
        private static int idActual;

        //Constructor al que le paso solo los valores más importantes
        public Producto(string nombre, ETipo tipo, float precio, int stock)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.precio = precio;
            this.stock = stock;
            this.marca = "N/A";
            this.descripcion = "N/A";
            this.id = idActual;
            idActual++;
        }
        //Constructor al que le paso todos los valores
        public Producto(string nombre, ETipo tipo, string marca, string descripcion,
                        float precio, int stock) :this(nombre, tipo, precio, stock)
        {
            this.marca = marca;
            this.descripcion = descripcion;
        }
        static Producto()
        {
            idActual = 1000;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public ETipo Tipo { get => tipo; set => tipo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE: {Nombre}");
            sb.AppendLine($"TIPO: {Tipo.ToString()}");
            sb.AppendLine($"MARCA: {Marca}");
            sb.AppendLine($"PRECIO: {Precio}");
            sb.AppendLine($"STOCK: {Stock}");
            sb.AppendLine($"DESCRIPCIÓN: {Descripcion}");
            return sb.ToString();
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.Id == p2.Id && p1.Nombre == p2.Nombre && p1.Marca == p2.Marca;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1.Id == p2.Id && p1.Nombre == p2.Nombre && p1.Marca == p2.Marca);
        }
    }
}
