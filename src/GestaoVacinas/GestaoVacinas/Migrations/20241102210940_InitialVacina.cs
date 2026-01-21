using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoVacinas.Migrations {
    /// <inheritdoc />
    public partial class InitialVacina : Migration {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.InsertData(
                table: "Vacinas",
                columns: new[] { "Nome", "Descricao", "IdadeEmMeses", "DataRecomendada", "IsVacinaPadrao" },
        values: new object[,]
        {
            { "BCG (dose única)", "Vacina BCG. Dose única recomendada ao nascer. Previne formas graves da Tuberculose (miliar e meníngea).", 0, null, true },
            { "Hepatite B (dose única)", "Vacina Hepatite B (recombinante HB). Dose única recomendada ao nascer. Previne Hepatite B.", 0, null, true },
            { "Pentavalente (1ª dose)", "Vacina adsorvida Difteria, Tétano, Pertussis, Hepatite B (recombinante) e Haemophilus influenzae B (conjugada) - (Penta). 1ª dose recomendada aos 2 meses. Previne Difteria, Tétano, Coqueluche, Hepatite B e infecções causadas pelo Haemophilus influenzae B.", 2, null, true },
            { "Poliomelite VIP (1ª dose)", "Vacina poliomielite 1, 2 e 3 (inativada) - (VIP). 1ª dose recomendada aos 2 meses. Previne Poliomielite.", 2, null, true },
            { "Pneumocócica 10 (Conjungada) (1ª dose)", "Vacina pneumocócica 10-valente (Conjugada) - (Pneumo 10). 1ª dose recomendada aos 2 meses. Previne infecções invasivas (como meningite e pneumonia) e otite média aguda, causadas pelos 10 sorotipos de Streptococus pneumoniae.", 2, null, true },
            { "Rotavírus (1ª dose)", "Vacina rotavírus humano G1P1 [8] (atenuada) - (VRH). 1ª dose recomendada aos 2 meses. Previne diarreia por rotavírus (Gastroenterites).", 2, null, true },
            { "Meningocócica C (conjugada) (1ª dose)", "Vacina meningocócica C (conjugada) - (Meningo C). 1ª dose recomendada aos 3 meses. Previne doença invasiva causada pela Neisseria meningitidis do sorogrupo C.", 3, null, true },
            { "Pentavalente (2ª dose)", "Vacina adsorvida Difteria, Tétano, Pertussis, Hepatite B (recombinante) e Haemophilus influenzae B (conjugada) - (Penta). 2ª dose recomendada aos 4 meses. Previne Difteria, Tétano, Coqueluche, Hepatite B e infecções causadas pelo Haemophilus influenzae B.", 4, null, true },
            { "Poliomelite VIP (2ª dose)", "Vacina poliomielite 1, 2 e 3 (inativada) - (VIP). 2ª dose recomendada aos 4 meses. Previne Poliomielite.", 4, null, true },
            { "Pneumocócica 10 (Conjungada) (2ª dose)", "Vacina pneumocócica 10-valente (Conjugada) - (Pneumo 10). 2ª dose recomendada aos 4 meses. Previne infecções invasivas (como meningite e pneumonia) e otite média aguda, causadas pelos 10 sorotipos de Streptococus pneumoniae.", 4, null, true },

            { "Rotavírus Humano (2ª dose)", "Vacina rotavírus humano G1P1 [8] (atenuada) - (VRH). 2ª dose recomendada aos 4 meses. Previne diarreia por rotavírus (Gastroenterites).", 4, null, true },
            { "Meningocócica C (conjugada) (2ª dose)", "Vacina meningocócica C (conjugada) - (Meningo C). 2ª dose recomendada aos 5 meses. Previne doença invasiva causada pela Neisseria meningitidis do sorogrupo C.", 5, null, true },
            { "Pentavalente (3ª dose)", "Vacina adsorvida Difteria, Tétano, Pertussis, Hepatite B (recombinante) e Haemophilus influenzae B (conjugada) - (Penta). 3ª dose recomendada aos 6 meses. Previne Difteria, Tétano, Coqueluche, Hepatite B e infecções causadas pelo Haemophilus influenzae B.", 6, null, true },
            { "Poliomelite VIP (3ª dose)", "Vacina poliomielite 1, 2 e 3 (inativada) - (VIP). 3ª dose recomendada aos 6 meses. Previne Poliomielite.", 6, null, true },
            { "Covid-19 (1ª dose)", "Vacina Covid-19. 1ª dose recomendada aos 6 meses. Previne as formas graves e complicações pela covid-19.", 6, null, true },
            { "Covid-19 (2ª dose)", "Vacina Covid-19. 2ª dose recomendada aos 7 meses. Previne as formas graves e complicações pela covid-19.", 7, null, true },
            { "Febre Amarela (uma dose)", "Vacina Febre Amarela (atenuada) - (FA). Dose recomendada aos 9 meses. Previne Febre amarela.", 9, null, true },
            { "Pneumocócica 10 (Conjungada) (reforço)", "Vacina pneumocócica 10-valente (Conjugada) - (Pneumo 10). Reforço recomendado aos 12 meses. Previne infecções invasivas (como meningite e pneumonia) e otite média aguda, causadas pelos 10 sorotipos de Streptococus pneumoniae.", 12, null, true },
            { "Meningocócica C (conjugada) (reforço)", "Vacina meningocócica C (conjugada) - (Meningo C). Reforço recomendado aos 12 meses. Previne doença invasiva causada pela Neisseria meningitidis do sorogrupo C.", 12, null, true },
            { "Tríplice Viral (1ª dose)", "Vacina Sarampo, Caxumba, Rubéola (Tríplice viral). 1ª dose recomendada aos 12 meses. Previne Sarampo, Caxumba e Rubéola.", 12, null, true },

            { "DTP (1º reforço)", "Vacina adsorvida Difteria, Tétano e pertussis (DTP). 1º reforço recomendado aos 15 meses. Previne Difteria, Tétano, Coqueluche.", 15, null, true },
            { "Poliomelite VOPb (1º reforço)", "Vacina Poliomielite 1 e 3 (atenuada) - (VOPb). 1º reforço recomendado aos 15 meses. Previne Poliomielite.", 15, null, true },
            { "Hepatite A (1 dose)", "Vacina adsorvida Hepatite A (HA - inativada). 1 dose recomendada aos 15 meses. Previne Hepatite A.", 15, null, true },
            { "Tetra Viral (1 dose)", "Vacina Sarampo, Caxumba, Rubéola, Varicela (Tetra Viral).1 dose recomendada aos 15 meses. Previne Sarampo, Caxumba, Rubéola e Varicela.", 15, null, true },
            { "DTP (2º reforço)", "Vacina adsorvida Difteria, Tétano e pertussis (DTP). 2º reforço recomendado aos 4 anos. Previne Difteria, Tétano, Coqueluche.", 48, null, true },
            { "Febre Amarela (reforço)", "Vacina Febre Amarela (atenuada) - (FA). Reforço recomendado aos 4 anos. Previne Febre Amarela.", 48, null, true },
            { "Poliomelite VOP (2º reforço)", "Vacina Poliomielite 1 e 3 (atenuada) - (VOPb). 2º reforço recomendado aos 4 anos. Previne Poliomielite.", 48, null, true },
            { "Varicela (1 dose)", "Vacina varicela (monovalente) - (Varicela). 1 dose recomendada aos 4 anos. Previne Varicela.", 48, null, true },
            { "HPV (dose única)", "Vacina HPV Papilomavírus humano 6, 11, 16 e 18 (HPV4 - recombinante). Dose única recomendada entre 9 e 10 anos. Previne Papilomavírus Humano 6, 11, 16 e 18.", 108, null, true },
            { "Meningocócica ACWY (uma dose)", "Vacina meningocócica ACWY (MenACWY- Conjugada).Dose recomendada entre 11 e 14 anos. Previne meningite meningocócica sorogrupos A, C, W e Y.", 132, null, true },

            { "BCG (dose)", "Vacina BCG. Previne formas graves da Tuberculose (miliar e meníngea).", null, null, false },
            { "Covid-19 (dose)", "Vacina Covid-19. Previne as formas graves e complicações pela covid-19.", null, null, false },
            { "Difteria e Tétano (dT) (dose)", "Vacina Difteria e Tétano (dT). Iniciar ou completar três doses, de acordo com situação vacinal. Reforço a cada 10 anos, ou a cada 5 anos em caso de ferimentos graves e contatos de difteria. Previne Difteria e Tétano.", null, null, false },
            { "DTP (dose)", "Vacina adsorvida Difteria, Tétano e pertussis (DTP). Previne Difteria, Tétano, Coqueluche.", null, null, false },
            { "Febre Amarela (dose)", "Vacina Febre Amarela (atenuada) - (FA). Previne Febre amarela.", null, null, false },
            { "Hepatite A (dose)", "Vacina adsorvida Hepatite A (HA - inativada). Previne Hepatite A.", null, null, false },
            { "Hepatite B (dose)", "Vacina Hepatite B (recombinante HB). Previne Hepatite B.", null, null, false },
            { "HPV (dose)", "Vacina HPV Papilomavírus humano 6, 11, 16 e 18 (HPV4 - recombinante). O intervalo entre doses deve ser confirmado na UBS. Previne Papilomavírus Humano 6, 11, 16 e 18.", null, null, false },
            { "Meningocócica ACWY (dose)", "Vacina meningocócica ACWY (MenACWY- Conjugada). Previne meningite meningocócica sorogrupos A, C, W e Y.", null, null, false },
            { "Meningocócica C (conjugada) (dose)", "Vacina meningocócica C (conjugada) - (Meningo C). Previne doença invasiva causada pela Neisseria meningitidis do sorogrupo C.", null, null, false },

            { "Pentavalente (dose)", "Vacina adsorvida Difteria, Tétano, Pertussis, Hepatite B (recombinante) e Haemophilus influenzae B (conjugada) - (Penta). Previne Difteria, Tétano, Coqueluche, Hepatite B e infecções causadas pelo Haemophilus influenzae B.", null, null, false },
            { "Pneumocócica 10 (Conjungada) (dose)", "Vacina pneumocócica 10-valente (Conjugada) - (Pneumo 10). Previne infecções invasivas (como meningite e pneumonia) e otite média aguda, causadas pelos 10 sorotipos de Streptococus pneumoniae.", null, null, false },
            { "Pneumocócica 23-valente (dose)", "Vacina pneumocócica 23-valente - (Pneumo 23). 1ª dose recomendada a partir de 5 anos de idade. 2ª dose deve ser feita 5 anos após a 1ª dose. Previne infecções invasivas pelo pneumococo na população indígena.", null, null, false },
            { "Poliomelite VIP (dose)", "Vacina poliomielite 1, 2 e 3 (inativada) - (VIP). Previne Poliomielite.", null, null, false },
            { "Poliomelite VOP (dose)", "Vacina Poliomielite 1 e 3 (atenuada) - (VOPb). Previne Poliomielite.", null, null, false },
            { "Rotavírus (dose)", "Vacina rotavírus humano G1P1 [8] (atenuada) - (VRH). Previne diarreia por rotavírus (Gastroenterites).", null, null, false },
            { "Tetra Viral (dose)", "Vacina Sarampo, Caxumba, Rubéola, Varicela (Tetra Viral). Previne Sarampo, Caxumba, Rubéola e Varicela.", null, null, false },
            { "Tríplice Viral (dose)", "Vacina Sarampo, Caxumba, Rubéola (Tríplice viral). Previne Sarampo, Caxumba e Rubéola.", null, null, false },
            { "Varicela (dose)", "Vacina varicela (monovalente) - (Varicela). Previne Varicela.", null, null, false },
            { "VSR (dose)", "Vacina contra o vírus sincicial respiratório (VSR). Previne infecções respiratórias graves, como bronquiolite e pneumonia, causadas pelo VSR.", null, null, false },

            { "Dengue (dose)", "Vacina tetravalente contra dengue (Dengvaxia). Previne formas graves e complicações causadas pelos quatro sorotipos do vírus da dengue.", null, null, false },
            { "Febre tifoide (dose)", "Vacina contra febre tifoide. Previne infecções causadas pela bactéria Salmonella typhi.", null, null, false },
            { "Influenza (dose)", "Vacina contra gripe (influenza) trivalente ou quadrivalente. Previne infecções causadas por três ou quatro cepas do vírus da gripe.", null, null, false },
            { "Hepatite A e B (dose)", "Vacina combinada contra hepatite A e B (recombinada). Previne infecções por hepatite A e hepatite B.", null, null, false },
            { "Herpes-zóster (dose)", "Vacina contra herpes-zóster (recombinante inativada). Previne herpes-zóster e neuralgia pós-herpética.", null, null, false },
            { "HPV9 (dose)", "Vacina contra papilomavírus humano 9-valente (HPV9). Previne infecções pelos tipos 6, 11, 16, 18, 31, 33, 45, 52 e 58 do HPV, protegendo contra cânceres relacionados ao HPV e verrugas genitais.", null, null, false },
            { "Meningocócicas B (dose)", "Vacina contra Neisseria meningitidis sorogrupo B (recombinante). Previne doenças invasivas causadas pelo sorogrupo B da bactéria Neisseria meningitidis.", null, null, false },
            { "Raiva (dose)", "Vacina antirrábica (inativada). Previne raiva após exposição ao vírus da raiva.", null, null, false },
        });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DeleteData(
                table: "Vacinas",
                keyColumn: "Nome",
                keyValues: new object[]
                {
                    "BCG (dose única)",
                    "Hepatite B (dose única)",
                    "Pentavalente (1ª dose)",
                    "Poliomelite VIP (1ª dose)",
                    "Pneumocócica 10 (Conjungada) (1ª dose)",
                    "Rotavírus (1ª dose)",
                    "Meningocócica C (conjugada) (1ª dose)",
                    "Pentavalente (2ª dose)",
                    "Poliomelite VIP (2ª dose)",
                    "Pneumocócica 10 (Conjungada) (2ª dose)",

                    "Rotavírus Humano (2ª dose)",
                    "Meningocócica C (conjugada) (2ª dose)",
                    "Pentavalente (3ª dose)",
                    "Poliomelite VIP (3ª dose)",
                    "Covid-19 (1ª dose)",
                    "Covid-19 (2ª dose)",
                    "Febre Amarela (uma dose)",
                    "Pneumocócica 10 (Conjungada) (reforço)",
                    "Meningocócica C (conjugada) (reforço)",
                    "Tríplice Viral (1ª dose)",

                    "DTP (1º reforço)",
                    "Poliomelite VOPb (1º reforço)",
                    "Hepatite A (1 dose)",
                    "Tetra Viral (1 dose)",
                    "DTP (2º reforço)",
                    "Febre Amarela (reforço)",
                    "Poliomelite VOP (2º reforço)",
                    "Varicela (1 dose)",
                    "HPV (dose única)",
                    "Meningocócica ACWY (uma dose)",

                    "BCG (dose)",
                    "Covid-19 (dose)",
                    "Difteria e Tétano (dT) (dose)",
                    "DTP (dose)",
                    "Febre Amarela (dose)",
                    "Hepatite A (dose)",
                    "Hepatite B (dose)",
                    "HPV (dose)",
                    "Meningocócica ACWY (dose)",
                    "Meningocócica C (conjugada) (dose)",

                    "Pentavalente (dose)",
                    "Pneumocócica 10 (Conjungada) (dose)",
                    "Pneumocócica 23-valente (dose)",
                    "Poliomelite VIP (dose)",
                    "Poliomelite VOP (dose)",
                    "Rotavírus (dose)",
                    "Tetra Viral (dose)",
                    "Tríplice Viral (dose)",
                    "Varicela (dose)",
                    "VSR (dose)",

                    "Dengue (dose)",
                    "Febre tifoide (dose)",
                    "Influenza (dose)",
                    "Hepatite A e B (dose)",
                    "Herpes-zóster (dose)",
                    "HPV9 (dose)",
                    "Meningocócicas B (dose)",
                    "Raiva (dose)"
                });
        }
    }
}
