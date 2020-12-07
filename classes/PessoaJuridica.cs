namespace POO_eranca.classes
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj;
        public string inscricaoEstadual;
        public string inscricaoMunicipal;
        public bool ValidarCNPJ(string documento){
            if (documento != "")
            {
                return true;
            }
            return false;
        }
        public bool ValidarIE(string documento){
            if (documento != "")
            {
                return true;
            }
            return false;
        }
        public bool ValidarIM(string documento){
            if (documento != "")
            {
                return true;
            }
            return false;
        }       
    }
}