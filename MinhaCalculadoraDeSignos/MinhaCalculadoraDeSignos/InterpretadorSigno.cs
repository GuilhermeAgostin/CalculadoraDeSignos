using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCalculadoraDeSignos
{
    class InterpretadorSigno
    {
        public Signo[] signos = new Signo[12];

        public InterpretadorSigno()
        {
            signos[0] = new Signo { diaInicio = 20, mesInicio = 1, diaFim = 18, mesFim = 2, nome = "Aquário", caracteristicas = "Aquário nos ensina a amizade, a fraternidade, a originalidade, a inovação, o respeito às diferenças, o amor incondicional ao ser humano e à natureza. Liberdade é a palavra de Aquário." };
            signos[1] = new Signo { diaInicio = 19, mesInicio = 2, diaFim = 20, mesFim = 3, nome = "Peixes", caracteristicas = "Peixes nos ensina a fé, a conexão com uma dimensão superior, a simplicidade, o desprendimento, a entrega à vida. Aceitação é a palavra de Peixes." };
            signos[2] = new Signo { diaInicio = 21, mesInicio = 3, diaFim = 19, mesFim = 4, nome = "Áries", caracteristicas = "Áries nos ensina a coragem, a liderança, o impulso, a motivação para iniciar projetos e seguir em frente, mesmo com obstáculos. Superação é a palavra de Áries." };
            signos[3] = new Signo { diaInicio = 20, mesInicio = 4, diaFim = 20, mesFim = 5, nome = "Touro", caracteristicas = "Touro nos ensina o cuidado, o carinho, a paciência para observar, ver crescer, acompanhar o próprio processo de desenvolvimento e o crescimento de outros. Persistência é a palavra de Touro." };
            signos[4] = new Signo { diaInicio = 21, mesInicio = 5, diaFim = 21, mesFim = 6, nome = "Gêmeos", caracteristicas = "Gêmeos nos ensina a comunicação, a boa palavra, a gentileza, a diplomacia para fazer contatos, transmitir informações e trocar opiniões com as pessoas. Conexão é a palavra de Gêmeos." };
            signos[5] = new Signo { diaInicio = 22, mesInicio = 6, diaFim = 22, mesFim = 7, nome = "Câncer", caracteristicas = "Câncer nos ensina o amor, a intimidade, a proteção, o aconchego e o suporte emocional para nos sentirmos queridos e seguros, participando de uma família. Pertencer é a palavra de Câncer." };
            signos[6] = new Signo { diaInicio = 23, mesInicio = 7, diaFim = 22, mesFim = 8, nome = "Leão", caracteristicas = "Leão nos ensina a criatividade, a alegria, a espontaneidade, a vaidade, a autoestima para seguirmos agindo corretamente e nos orgulhando de nós mesmos. Nobreza é a palavra de Leão." };
            signos[7] = new Signo { diaInicio = 23, mesInicio = 8, diaFim = 22, mesFim = 9, nome = "Virgem", caracteristicas = "Virgem nos ensina a produtividade, o amor ao trabalho, o desejo de ser útil, de servir, de ajudar a nós mesmos e às outras pessoas. Eficiência é a palavra de Virgem." };
            signos[8] = new Signo { diaInicio = 23, mesInicio = 9, diaFim = 22, mesFim = 10, nome = "Libra", caracteristicas = "Libra nos ensina o compromisso, o laço, o engajamento com os outros, a sofisticação, o amor às artes e a delicadeza que encanta e cativa as pessoas ao redor. Charme é a palavra de Libra." };
            signos[9] = new Signo { diaInicio = 23, mesInicio = 10, diaFim = 21, mesFim = 11, nome = "Escorpião", caracteristicas = "Escorpião nos ensina o silêncio, a profundidade, o mistério, as emoções, a possibilidade de nos despojar e nos transformar em pessoas melhores. Transcendência é a palavra de Escorpião." };
            signos[10] = new Signo { diaInicio = 22, mesInicio = 11, diaFim = 21, mesFim = 12, nome = "Sagitário", caracteristicas = "Sagitário nos ensina a esperança, a fé no futuro, a energia positiva, o interesse em ir muito mais longe para descobrir que o mundo é maior. Expansão a palavra de Sagitário." };
            signos[11] = new Signo { diaInicio = 22, mesInicio = 12, diaFim = 19, mesFim = 1, nome = "Capricórnio", caracteristicas = "Capricórnio nos ensina a responsabilidade, a disciplina, a ética, a sabedoria obtida pela idade, o respeito aos mais velhos, a força de vontade. Consciência é a palavra de Capricórnio." };
        }

        public Signo Interpretar(int dia, int mes)
        {
            Signo signo = null;

            for (int i = 0; i < signos.Length; i++)
            {
                if ((signos[i].mesInicio == mes && dia >= signos[i].diaInicio) || (signos[i].mesFim == mes && dia <= signos[i].diaFim))
                {
                    signo = signos[i];
                    break;
                }
            }

            return signo;
        }
    }
}
