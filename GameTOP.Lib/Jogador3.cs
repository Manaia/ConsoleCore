using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : IJogador
    {
        public string Chuta()
        {
            return "Teste Chuta";
        }

        public string Corre()
        {
            return "Teste Corre";
        }

        public string Passe()
        {
            return "Teste Passe";
        }
    }
}