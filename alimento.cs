class Alimento :  Articulo{
    string fecha="";
    string tipoAlimento;
   public Alimento(string codigo,string nombre,string marca, int cant, double precioU,string fecha, string tipoA):base(codigo,nombre,marca,cant,precioU){
    this.fecha=fecha;
    tipoAlimento = tipoA;
   }
    public override string ToString()
    {
        return $"Codigo: {codigo}\n Nombre:{nombre} \n Marca: {marca}\n Cantidad: {cantidad}\n Precio unitario: {precioUnitario}\n Fecha de Caducidad: {fecha}\n Tipo de alimento: {tipoAlimento}";
    }
}