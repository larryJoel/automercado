class Fresco: Articulo{
    string tipo="";
    double peso;
    public Fresco(string codigo,string nombre,string marca, int cant, double precioU,string tipo, double peso):base(codigo,nombre,marca,cant,precioU){
        
        this.tipo = tipo;
        this.peso = peso;

}
    public override string ToString()
    {
        return base.ToString()+"Tipo: "+tipo+" ,peso: "+peso;
    }
}