class Articulo{
    public string codigo;
    public string nombre;
    public string marca;
    public int cantidad;
    public double precioUnitario;

    public Articulo(string codigo, string nombre, string marca, int cantidad, double precioUnitario)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.marca = marca;
        this.cantidad = cantidad;
        this.precioUnitario = precioUnitario;
    }

    public override string ToString()
    {
        return $"codigo:{codigo} \n"
            + $"nombre: {nombre}\n"
            + $"marca: {marca}\n"
            + $"cantidad: {cantidad}\n"
            + $"precio Unitairio: {precioUnitario}$\n";
    }
}