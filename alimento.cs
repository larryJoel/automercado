class Alimento :  Articulo{
    string fecha;
    string tipoAlimento;
    Alimento(string codigo, string nombre, string marca, int cantidad, double precioUnitario,string f, string tipo):base(codigo, nombre,marca,cantidad,precioUnitario){
        this.fecha = f;
        tipoAlimento = tipo;
    }
}