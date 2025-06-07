﻿namespace drakaysa.Models
{
    public class Endereco
    {

        public int Id { get; set; }
        public string? CEP { get; set; }
        public string? Rua { get; set; }
        public string? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? Descricao { get; set; } //Esse campo irá mostrar todos os anteriores como uma string. Para assim, ser selecionado no front para escolha de um endereco do dentista

        public override string ToString()
        {
            return $"{Rua}, {Numero} - {Bairro} - {Cidade} - {Estado} - {CEP}";
        }

        public void GerarDescricao()
        {
            Descricao = ToString();
        }
    }

}
