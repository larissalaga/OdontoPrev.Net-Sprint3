using System;
using System.Collections.Generic;
using OdontoPrevAPI.Dtos;

namespace OdontoPrevAPI.Tools
{
    public static class DadosDeTestes
    {
        public static List<PlanoDtos> ListaPlanos = new()
        {
            new PlanoDtos { DsCodigoPlano = "ODP001", NmPlano = "B�sico" },
            new PlanoDtos { DsCodigoPlano = "ODP002", NmPlano = "Intermedi�rio" },
            new PlanoDtos { DsCodigoPlano = "ODP003", NmPlano = "Premium" },
            new PlanoDtos { DsCodigoPlano = "ODP004", NmPlano = "Empresarial" },
            new PlanoDtos { DsCodigoPlano = "ODP005", NmPlano = "Familiar" },
            new PlanoDtos { DsCodigoPlano = "ODP006", NmPlano = "Executivo" },
            new PlanoDtos { DsCodigoPlano = "ODP007", NmPlano = "Estudante" },
            new PlanoDtos { DsCodigoPlano = "ODP008", NmPlano = "Infantil" },
            new PlanoDtos { DsCodigoPlano = "ODP009", NmPlano = "Senior" },
            new PlanoDtos { DsCodigoPlano = "ODP010", NmPlano = "Master" }
        };

        public static List<DentistaDtos> ListaDentistas = new()
        {
            new DentistaDtos { NmDentista = "Dr. Otto Canino", DsCro = "CRO312544", DsEmail = "otto.canino@gmail.com", NrTelefone = "31932158752", DsDocIdentificacao = "12579320000127" },
            new DentistaDtos { NmDentista = "Dr. Ben Dente", DsCro = "CR245565", DsEmail = "ben.dente@gmail.com", NrTelefone = "62901985212", DsDocIdentificacao = "16874896000178" },
            new DentistaDtos { NmDentista = "Dr. �lvaro Canal", DsCro = "CR52865", DsEmail = "alvaro.canal@gmail.com", NrTelefone = "11999855776", DsDocIdentificacao = "59225989000184" },
            new DentistaDtos { NmDentista = "Dra. Marina Molar", DsCro = "CR986422", DsEmail = "marina.molar@gmail.com", NrTelefone = "11933255774", DsDocIdentificacao = "93908189000104" },
            new DentistaDtos { NmDentista = "Dr. Ali Vramento", DsCro = "CR098964", DsEmail = "ali.vramento@gmail.com", NrTelefone = "45988552211", DsDocIdentificacao = "75234663000170" },
            new DentistaDtos { NmDentista = "Dra. Aparecida do Sorriso", DsCro = "CRO99001", DsEmail = "aparecida.sorriso@gmail.com", NrTelefone = "84966665786", DsDocIdentificacao = "42526327000141" },
            new DentistaDtos { NmDentista = "Dra. Isa Carie", DsCro = "CR856934", DsEmail = "isa.carie@gmail.com", NrTelefone = "11955863320", DsDocIdentificacao = "07316233000147" },
            new DentistaDtos { NmDentista = "Dra. Clara Mente", DsCro = "CR125863", DsEmail = "clara.mente@gmail.com", NrTelefone = "33945633251", DsDocIdentificacao = "36816900000159" },
            new DentistaDtos { NmDentista = "Dr. Cl�udio Gengiva", DsCro = "CRO88990", DsEmail = "claudio.gengiva@gmail.com", NrTelefone = "27337558861", DsDocIdentificacao = "46805824000130" },
            new DentistaDtos { NmDentista = "Dra. Sonia Brilho", DsCro = "CR203587", DsEmail = "sonia.brilho@gmail.com", NrTelefone = "63977523258", DsDocIdentificacao = "50241419000103" }
        };

        public static List<PacienteDtos> ListaPacientes = new()
        {
            new PacienteDtos { NmPaciente = "Beto Mal H�lito", DtNascimento = DateTime.Parse("1990-02-06"), NrCpf = "09317440088", DsSexo = "M", NrTelefone = "27965563215", DsEmail = "beto.halito@gmail.com", IdPlano = 1 },
            new PacienteDtos { NmPaciente = "Branca Dente", DtNascimento = DateTime.Parse("1987-10-31"), NrCpf = "00780976061", DsSexo = "F", NrTelefone = "11975853524", DsEmail = "branca.dente@gmail.com", IdPlano = 2 },
            new PacienteDtos { NmPaciente = "Geni giva", DtNascimento = DateTime.Parse("1995-01-18"), NrCpf = "39600754055", DsSexo = "F", NrTelefone = "31963254785", DsEmail = "geni.giva@gmail.com", IdPlano = 3 },
            new PacienteDtos { NmPaciente = "Jo�o T�rtaro", DtNascimento = DateTime.Parse("1992-02-06"), NrCpf = "12724268075", DsSexo = "M", NrTelefone = "35932100586", DsEmail = "joao.tartaro@gmail.com", IdPlano = 4 },
            new PacienteDtos { NmPaciente = "Carie Alves", DtNascimento = DateTime.Parse("1983-11-25"), NrCpf = "44797031018", DsSexo = "N", NrTelefone = "45932014563", DsEmail = "carie.alves@gmail.com", IdPlano = 5 },
            new PacienteDtos { NmPaciente = "Sara Dente", DtNascimento = DateTime.Parse("1991-08-20"), NrCpf = "23953879081", DsSexo = "N", NrTelefone = "54946852335", DsEmail = "sara.dente@gmail.com", IdPlano = 6 },
            new PacienteDtos { NmPaciente = "Ligia Dor", DtNascimento = DateTime.Parse("1988-06-30"), NrCpf = "35423149002", DsSexo = "F", NrTelefone = "11985652545", DsEmail = "ligia.dor@gmail.com", IdPlano = 7 },
            new PacienteDtos { NmPaciente = "Ryan Quebrado", DtNascimento = DateTime.Parse("1990-09-01"), NrCpf = "67641380018", DsSexo = "N", NrTelefone = "25975254562", DsEmail = "ryan.quebrado@gmail.com", IdPlano = 8 },
            new PacienteDtos { NmPaciente = "Ronaldo Banguela", DtNascimento = DateTime.Parse("1994-03-22"), NrCpf = "93430420008", DsSexo = "M", NrTelefone = "11998547565", DsEmail = "ronaldo.banguela@gmail.com", IdPlano = 5 },
            new PacienteDtos { NmPaciente = "Josefina Quebra Queixo", DtNascimento = DateTime.Parse("1985-03-09"), NrCpf = "91952855047", DsSexo = "F", NrTelefone = "32963254777", DsEmail = "josefina.quebra.queixo@gmail.com", IdPlano = 10 }
        };

        public static List<string> ListaPerguntas = new()
        {
            "Voc� � fumante?",
            "Voc� ja visitou um dentista esse ano?",
            "Voc� sente dor ao mastigar?",
            "Voc� j� fez limpeza dent�ria esse ano?",
            "Voc� j� escovou os dentes hoje?",
            "Voc� tem algum problema de gengiva?",
            "Voc� ja fez tratamento de canal?",
            "Voc� usa fio dental regularmente?",
            "Voc� j� extraiu algum dente?",
            "Voc� masca chicletes com frequ�ncia?"
        };

        public static List<(string Data, int Pontos, string Descricao, int IdPaciente)> ListaExtratoPontos = new()
        {
            ("25/05/2022", 100, "Respondeu a pergunta", 2),
            ("13/12/2019", 150, "Resgatou pontos", 2),
            ("05/05/2024", 200, "Respondeu a pergunta", 2),
            ("03/02/2024", 250, "Enviou Raio X", 2),
            ("09/07/2022", 300, "Fez uma limpeza", 2),
            ("28/04/2021", 350, "Fez uma avalia��o", 2),
            ("07/07/2023", 400, "Resgatou pontos", 2),
            ("19/11/2023", 450, "Respondeu a pergunta", 2),
            ("27/06/2022", 500, "Fez uma limpeza", 2),
            ("22/07/2020", 550, "Enviou Raio X", 2)
        };

        public static List<string> Respostas = new()
        {
            "Sim",
            "N�o",
            "Sim",
            "Sim",
            "N�o",
            "Sim",
            "N�o",
            "Sim",
            "N�o",
            "Sim"
        };

        public static List<(string Data, int IdPaciente, int IdPergunta, int IdResposta)> CheckIn = new()
        {
            ("02/02/2024", 3, 1, 1),
            ("02/02/2024", 3, 2, 2),
            ("02/02/2024", 3, 3, 3),
            ("02/02/2024", 3, 4, 4),
            ("02/02/2024", 3, 5, 5),
            ("02/02/2024", 3, 6, 6),
            ("02/02/2024", 3, 7, 7),
            ("02/02/2024", 3, 8, 8),
            ("02/02/2024", 3, 9, 9),
            ("02/02/2024", 3, 10, 10)
        };

        public static List<(string Descricao, byte[] Imagem, string Data, int IdPaciente)> ListaRaioX = new()
        {
            ("Raio_x do siso", null, "02/01/2024", 1),
            ("Raio_x do molar", null, "05/02/2024", 2),
            ("Raio_x do pr�-molar", null, "08/03/2024", 3),
            ("Raio_x do canino", null, "11/04/2024", 4),
            ("Raio_x panor�mico", null, "15/05/2024", 5),
            ("Raio_x da mand�bula", null, "19/06/2024", 6),
            ("Raio_x do maxilar", null, "23/07/2024", 7),
            ("Raio_x do incisivo", null, "28/08/2024", 8),
            ("Raio_x do canino", null, "02/09/2024", 9),
            ("Raio_x do molar", null, "06/10/2024", 10)
        };

        public static List<(string Descricao, string Data, int IdRaioX)> ListaAnaliseRaioX = new()
        {
            ("C�ries nos dentes superiores", "05/01/2024", 1),
            ("Infec��o no dente molar", "10/02/2024", 2),
            ("Abscesso no pr�-molar", "15/03/2024", 3),
            ("Perda �ssea devido � periodontite", "20/04/2024", 4),
            ("Dente impactado no siso inferior", "25/05/2024", 5),
            ("Les�o �ssea na mand�bula", "30/06/2024", 6),
            ("Fratura dent�ria no incisivo", "05/07/2024", 7),
            ("Dente supranumer�rio detectado no maxilar superior", "10/08/2024", 8),
            ("Cisto dent�rio em forma��o ao redor do canino", "15/09/2024", 9),
            ("C�rie radicular no molar inferior direito", "20/10/2024", 10)
        };

        public static List<(int IdPaciente, int IdDentista)> ListaPacienteDentista = new()
        {
            (1, 1),
            (2, 2),
            (3, 3),
            (4, 4),
            (5, 5),
            (6, 6),
            (7, 7),
            (8, 8),
            (9, 9),
            (10, 10)
        };
    }
}

