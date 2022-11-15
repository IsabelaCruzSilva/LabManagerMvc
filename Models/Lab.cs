namespace MvcLabManager.Models;

public class Lab
{
    public int Id { get; set; }
    public string Ram { get; set; }
    public string Processor { get; set; }

    public Lab() { }

    public Lab(int id, string numero, string nome, string bloco)
    {
        Id = id;
        Numero = numero;
        Nome = nome;
        Bloco = bloco; 
        
    }
}