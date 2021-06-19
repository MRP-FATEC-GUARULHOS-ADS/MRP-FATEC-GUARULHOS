using System.Collections.Generic;

namespace MRP_SacoCarvao
{
    public class Componente
    {
        // Atributos
        public int idComponente { get; set; }
        public string tipoComponente { get; set; }
        public string modeloComponente { get; set; }
        public int qtdeMinEstoque { get; set; }
        public int qtdeMaxEstoque { get; set; }
        public int qtdeAtualEstoque { get; set; }
        public string especificacao { get; set; }

        // Construtores
        public Componente() {
            
        }

        public Componente(
            int idComp,
            string tipoComp, string modeloComp,
            int qtdeMinEst = 0, int qtdeMaxEst = 0, int qtdeAtualEst = 0,
            string espec = null
        ) {
            this.idComponente = idComp;
            this.tipoComponente = tipoComp;
            this.modeloComponente = modeloComp;
            this.qtdeMinEstoque = qtdeMinEst;
            this.qtdeMaxEstoque = qtdeMaxEst;
            this.qtdeAtualEstoque = qtdeAtualEst;
            this.especificacao = espec;
        }

        public override string ToString()
        {
            return this.modeloComponente;
        }

        public List<string> GetEspecificacoes ()
        {
            List<string> especs = new List<string>();
            switch (tipoComponente)
            {
                case "HD":
                    especs.Add("Formato");
                    especs.Add("Capacidade");
                    especs.Add("RPM");
                    break;
                case "SSD":
                    especs.Add("Capacidade");
                    especs.Add("Interface");
                    break;
                case "Memória RAM":
                    especs.Add("Medidas (mm x mm x mm)");
                    especs.Add("Capacidade");
                    especs.Add("DDR");
                    especs.Add("Frequência");
                    break;
                case "Placa de Vídeo":
                    especs.Add("Medidas (mm x mm x mm)");
                    especs.Add("Memória");
                    especs.Add("GDDR");
                    especs.Add("Barramento");
                    break;
                case "Placa Mãe":
                    especs.Add("Formato");
                    especs.Add("Socket");
                    especs.Add("Quantidade de slots de memória RAM");
                    especs.Add("Slots de Expansão");
                    break;
                case "Processador":
                    especs.Add("Núcleos");
                    especs.Add("Threads");
                    especs.Add("Memória Cache");
                    especs.Add("Socket");
                    especs.Add("Frequência Base");
                    especs.Add("Turbo");
                    break;
                case "Sistema":
                    especs.Add("Bits");
                    break;
                case "Tela":
                    especs.Add("Tecnologia");
                    especs.Add("Resolução");
                    especs.Add("Formato");
                    break;
                default:
                    especs.Clear();
                    break;
            }
            return especs;
        }

    }
}
