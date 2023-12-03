PessoaFisica pf1 = new();
pf1.Nome = "leleco";
pf1.Cpf = "000.000.000-00";
pf1.Salvar();
pf1.Salvar("pessoa fisica");
Console.WriteLine(pf1.getNumeroConta());

PessoaJuridica pj1 = new();
pj1.Nome = "jaleco";
pj1.Cnpj = "0000000001-0";
pj1.Salvar();
Console.WriteLine(pj1.getNumeroConta());