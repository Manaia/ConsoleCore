using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador : IJogador
    {
        public readonly string _Nome;

        public Jogador(string nome)
        {
            _Nome = nome;
        }

        public string Chuta()
        {
            return $"{_Nome} está chutando \n";
        }

        public string Corre()
        {
            return $"{_Nome} está correndo \n";
        }

        public string Passe()
        {
            return $"{_Nome} está passando \n";
        }
    }
}