using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        class Cliente
        {
            private int codigo;
            private string endereco;
            private string telefone;

            protected int GetCodigo()
            {
                return codigo;
            }

            protected void SetCodigo(int codigo)
            {
                this.codigo = codigo;
            }

            protected string GetEndereco()
            {
                return endereco;
            }

            protected void SetEndereco(string endereco)
            {
                this.endereco = endereco;
            }

            protected string GetTelefone()
            {
                return Convert.ToUInt64(telefone).ToString(@"(00)00000-0000");
            }

            protected void SetTelefone(string telefone)
            {
                this.telefone = telefone;
            }
        }

        class PessoaFisica : Cliente
        {
            private string nome;
            private string cpf;

            public PessoaFisica SetPessoaFisica(int codigo, string nome, string cpf, string endereco, string telefone)
            {
                this.SetCodigo(codigo);
                this.SetNome(nome);
                this.SetCpf(cpf);
                this.SetEndereco(endereco);
                this.SetTelefone(telefone);
                return this;
            }

            protected string GetNome()
            {
                return nome;
            }

            protected void SetNome(string nome)
            {
                this.nome = nome;
            }

            protected string GetCpf()
            {
                return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
            }

            protected void SetCpf(string cpf)
            {
                this.cpf = cpf;
            }

            public string mostrar()
            {
                return "\nCódigo: " + GetCodigo() +
                       "\nNome: " + GetNome() +
                       "\nCPF: " + GetCpf() +
                       "\nEndereço: " + GetEndereco() +
                       "\nTelefone: " + GetTelefone();    
            }
        }

        class PessoaJuridica : Cliente
        {
            private string razaoSocial;
            private string cnpj;

            public PessoaJuridica SetPessoaJuridica(int codigo, string razaoSocial, string cnpj, string endereco, string telefone)
            {
                this.SetCodigo(codigo);
                this.SetRazaoSocial(razaoSocial);
                this.SetCnpj(cnpj);
                this.SetEndereco(endereco);
                this.SetTelefone(telefone);
                return this;
            }
             protected string GetRazaoSocial()
            {
                return razaoSocial;
            }

            protected void SetRazaoSocial(string razaoSocial)
            {
                this.razaoSocial = razaoSocial;
            }

            protected string GetCnpj()
            {
                return Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\-00");
            }

            protected void SetCnpj(string cnpj)
            {
                this.cnpj = cnpj;
            }

            public string mostrar()
            {
                return "\nCódigo: " + GetCodigo() +
                       "\nRazão Social: " + GetRazaoSocial() +
                       "\nCNPJ: " + GetCnpj() +
                       "\nEndereço: " + GetEndereco() +
                       "\nTelefone: " + GetTelefone();
            }
        }

        class Inicio
        {
            static void Main(string[] args)
            {
                int vet = 10;
                int opcao = 0;
                string pessoa;
                int removeCliente = 0;

                int codigo = 1;
                string nome = "";
                string cpf = "";
                string endereco = "";
                string telefone = "";
                string razaoSocial = "";
                string cnpj = "";

                PessoaFisica[] clientePF = new PessoaFisica[vet];
                PessoaJuridica[] clientePJ = new PessoaJuridica[vet];

                do
                {
                    Console.Write("\n0 - Encerrar Programa: \n");
                    Console.Write("\n1 - Inserir Cliente: \n");
                    Console.Write("\n2 - Remover Cliente: \n");
                    Console.Write("\n3 - Consultar Clientes: \n");

                    Console.Write("\n\nEscolha uma opção: \n");
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("O cliente é Pessoa Física (PF) ou Pessoa Jurídica (PJ)? ");
                            pessoa = Console.ReadLine();

                            if (pessoa.Equals("PF", StringComparison.CurrentCultureIgnoreCase))
                            {
                                Console.WriteLine("\nCadastro de Pessoa Física (PF).\n");
                                PessoaFisica pessoafisica = new PessoaFisica();
                                Console.WriteLine("Digite algumas informações do cliente que deseja cadastrar: ");
                                Console.WriteLine("\nNome: ");
                                nome = Console.ReadLine();
                                Console.WriteLine("\nCPF: ");
                                cpf = Console.ReadLine();
                                Console.WriteLine("\nEndereço: ");
                                endereco = Console.ReadLine();
                                Console.WriteLine("\nTelefone: ");
                                telefone = Console.ReadLine();
                                clientePF[codigo - 1] = pessoafisica.SetPessoaFisica(codigo, nome, cpf, endereco, telefone);
                                codigo++;
                                Console.WriteLine("\nCliente (PF) inserido com sucesso.");
                                Console.WriteLine("\nAperte qualquer tecla para continuar.");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            else if (pessoa.Equals("PJ", StringComparison.CurrentCultureIgnoreCase))
                            {
                                Console.WriteLine("\nCadastro de Pessoa Jurídica (PJ).\n");
                                PessoaJuridica pessoajuridica = new PessoaJuridica();
                                Console.WriteLine("\nDigite algumas informações do cliente que deseja cadastrar: ");
                                Console.WriteLine("\nRazão Social: ");
                                razaoSocial = Console.ReadLine();
                                Console.WriteLine("\nCNPJ: ");
                                cnpj = Console.ReadLine();
                                Console.WriteLine("\nEndereço:");
                                endereco = Console.ReadLine();
                                Console.WriteLine("\nTelefone:");
                                telefone = Console.ReadLine();
                                clientePJ[codigo - 1] = pessoajuridica.SetPessoaJuridica(codigo, razaoSocial, cnpj, endereco, telefone);
                                codigo++;
                                Console.WriteLine("\nCliente (PJ) inserido com sucesso.");
                                Console.WriteLine("\nAperte qualquer tecla para continuar.");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nCliente NÃO foi inserido.");
                                Console.WriteLine("A opção digitada é inválida.");
                            }
                                break;

                        case 2:
                            Console.Write("\n\nPessoa Física (PF) ou Pessoa Jurídica (PJ): ");
                            pessoa = Console.ReadLine();

                            if (pessoa == "PF")
                            {
                                Console.WriteLine("Remover Pessoa Física (PF): ");

                                Console.Write("Digite o código do cliente: ");
                                removeCliente = int.Parse(Console.ReadLine());
                                for (int i = removeCliente - 1; i < removeCliente; i++)
                                {
                                    if (clientePF[i] != null)
                                    {
                                        clientePF[i] = null;
                                        Console.WriteLine("Cliente (PF) removido com sucesso! ");
                                        removeCliente = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nNenhum cliente foi cadastrado ou algo está errado.");
                                        break;
                                    }
                                }
                            }
                            else if (pessoa == "PJ")
                            {
                                Console.WriteLine("Remover Pessoa Jurídica (PJ): ");

                                Console.Write("Digite o código do cliente: ");
                                removeCliente = int.Parse(Console.ReadLine());
                                for (int i = removeCliente - 1; i < removeCliente; i++)
                                {
                                    if (clientePJ[i] != null)
                                    {
                                        clientePJ[i] = null;
                                        Console.WriteLine("Cliente (PJ) removido com sucesso! ");
                                        removeCliente = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nNenhum cliente foi cadastrado ou algo está errado.");
                                        break;
                                    }
                                }
                            } 
                            else
                            {
                                Console.WriteLine("\nTipo de cliente inválido. ");
                                break;
                            }
                            Console.WriteLine("\nAperte qualquer tecla para continuar.");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 3:
                            Console.WriteLine("\nPessoas Físicas: \n");
                            for (int i = 0; i < clientePF.Length; i++)
                            {
                                if (clientePF[i] == null)
                                {
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine(clientePF[i].mostrar());
                                }
                            }
                          
                            Console.WriteLine("\nPessoas Jurídicas: \n");
                            for (int i = 0; i < clientePJ.Length; i++)
                            {
                                if (clientePJ[i] == null)
                                {
                                    continue;
                                }
                                else
                                {
                                    Console.Write(clientePJ[i].mostrar());
                                } 
                            }
                            Console.WriteLine("\nAperte qualquer tecla para continuar.");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("A opção digitada é inválida.");
                            break;
                    }
                } while (opcao != 0);
            }
        }
    }
}