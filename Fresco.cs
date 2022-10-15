class Fresco: Articulo{
    string tipo="";
    double peso;
    public Fresco(string codigo,string nombre,string marca, int cant, double precioU,string tipo, double peso):base(codigo,nombre,marca,cant,precioU){
        
        this.tipo = tipo;
        this.peso = peso;

}
    public override string ToString()
    {
         return $"Codigo: {codigo}\n Nombre:{nombre} \n Marca: {marca}\n Cantidad: {cantidad}\n Precio unitario: {precioUnitario}\n Tipo: {tipo}, peso: {peso}";
    }
}