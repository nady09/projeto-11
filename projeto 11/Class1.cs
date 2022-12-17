using System;
using System.Collections.Generic;
using System.Text;

namespace projeto_11
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    class compra
    {

        private string cliente { get; set; }
        private string data { get; set; }
        private static material[] materiais = new material[];
        private static int nmateriais;

        public static void MaterialInserir(material obj)
        {
            if (nmaterial == materiais.Length)
                Array.Resize(ref materiais, 2 * materiais.Length);
            materiais[nmateriais] obj;
            nmateriais++;

        }
        public static material[] materiallistar()
        {
            material[] aux = new material[nmateriais];
            Array.Copy(materiais, aux, nmateriais);
            return aux;
        }
        public static material[] materiasllistar(int id)
        {
            foreach (material obj) in materiais)
                    if (obj != null && obj.GetIdmateriais() == id) return obj;

        }
        public override string ToString()
        {
            return $"{cliente} {data} {materiais}";
        }
        class Materiais
        {
            private string nome;
            private double preco;
            private int quantidade;
            public Veiculo(int idmaterial, string nome, double preco, int quantidade}{
                this.IdMaterial=idmaterial;
                this.nome=nome
                this.preco= preco
                this.quantidad= quantidade
                }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public void SetPreco(double preco)
        {
            this.preco = preco;
        }
        public void SetQuantidade(int quantidade)
        {
            this.quantidade = quantidade
            }
        public void SetQuantidadr(int idmaterial)
        {
            this.quantidade = quantidade;
        }
        public void SetMaterial(int idmaterial)
        {
            this.idmaterial = idmaterial;
        }
        public dougle Getpreco()
        {
            return preco;
        }
        public string Getnome()
        {
            return nome;
        }
        public int GetQuantidade()
        {
            return quantidade;
        }
        public int GetIdMaterial()
        {
            return Idmaterial;
        }
        public overridr string ToString()
        {
            return $"ID: {IdMaterial}\n Nome: {nome}\n
            Quantidade: { quantidade}\n Preco:{ preco}
            ";
            }