class Limpieza:Articulo{
    string embase="";
    string tipo="";
    public Limpieza(string codigo,string nombre,string marca, int cant, double precioU,string emb,string tip):base(codigo,nombre,marca,cant,precioU){
        embase=emb;
        tipo = tip;
    }
    public override string ToString()
    {
        return base.ToString()+$"Embase:{embase}\n Tipo de artículo:{tipo}";
    }
}