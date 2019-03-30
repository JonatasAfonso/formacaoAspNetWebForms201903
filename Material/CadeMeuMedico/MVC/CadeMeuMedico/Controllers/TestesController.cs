using CadeMeuMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class TestesController : Controller
    {
        public List<Usuario> GetTestes()
        {
            var db = new CadeMeuMedicoDB();
            var usuarios = db.Usuarios.ToList();

            return usuarios;
        }

        public String GetUsuarios()
        {
            var db = new CadeMeuMedicoDB();
            var usuarios = db.Usuarios.ToList();
            var resultado = new StringBuilder();

            foreach (var item in usuarios)
            {
                resultado.AppendLine("|Nome: " + item.Nome + " |Email: " + item.Email
                    + " |ConfirmacaoEmail: " + item.ConfirmacaoEmail + " |Senha: " + item.Senha + "<br>");
            }

            return resultado.ToString();
        }

        private String GetSenha(string hash)
        {
            var db = new CadeMeuMedicoDB();
            var senha = db.DicionarioHash.FirstOrDefault(x => x.HashCriptografado == hash);
            var senhaAberta = "";

            if (senha != null)
                senhaAberta = senha.SenhaEmAberto;

            return senhaAberta;
        }

        public String GetSenhaDoUsuario()
        {
            var db = new CadeMeuMedicoDB();
            var usuarios = db.Usuarios.ToList();
            var resultado = new StringBuilder();

            foreach (var item in usuarios)
            {

                var SenhaAberto = GetSenha(hash: item.Senha);

                //resultado.AppendLine("|Nome: " + item.Nome + " |Email: " + item.Email
                //    + " |ConfirmacaoEmail: " + item.ConfirmacaoEmail + " |Hash: " + item.Senha 
                //    +  " |Senha: " + SenhaAberto + "<br>");


                resultado.AppendLine($@"|Nome: {item.Nome} |Email: {item.Email} |ConfirmacaoEmail: {item.ConfirmacaoEmail} |Hash: {item.Senha}  |Senha: { SenhaAberto} <br />");

            }

            return resultado.ToString();
        }


        public void AddUsuario()
        {
            var db = new CadeMeuMedicoDB();
            var novoUsuario = new Usuario
            {
                Nome = "Maria",
                Email = "maria@email.com",
                ConfirmacaoEmail = "maria@email.com",
                Senha = "senha"
            };

            db.Usuarios.Add(novoUsuario);
            db.SaveChanges();

        }

        public string GetEmailComecandoCom(string inicio)
        {
            var db = new CadeMeuMedicoDB();

            var usuariosComFiltro = db.Usuarios.ToList()
                .Where(x => x.Email.StartsWith(inicio))
                .Where(y => y.Senha != "");

            var resultado = new StringBuilder();

            foreach (var item in usuariosComFiltro)
            {
                resultado.AppendLine("|Nome: " + item.Nome + " |Email: " + item.Email + "<br>");
            }

            return resultado.ToString();
        }

        public void ApagarTodos()
        {
            var db = new CadeMeuMedicoDB();
            var todosUsuarios = db.Usuarios.ToList();

            foreach (var item in todosUsuarios)
            {
                db.Usuarios.Remove(item);
            }

            //db.Usuarios.RemoveRange(db.Usuarios);

            db.SaveChanges();
        }

        public void AdicionarUsuarioDados(string nome, string email, string confirmacao, string senha)
        {
            //var db = new CadeMeuMedicoDB();
            //var novoUsuario = new Usuario

            var novoUsuario = new Usuario //criação do novo objecto usuario
            {
                Nome = nome,
                Email = email,
                ConfirmacaoEmail = confirmacao,
                Senha = CalculateMD5Hash(senha)
            };

            var db = new CadeMeuMedicoDB();
            // se encontrar um email igual, ou seja, o numero de emails iguais
            // for superior a 0, não adiciona o usuario
            /*if (db.Usuarios.Where(x => x.Email == email).Count() > 0) 
            {
                ///mensagem de erro
            }*/
            if (db.Usuarios.Any(x => x.Email == email))
            {
                ///mensagem de erro
            }
            else
            {
                db.Usuarios.Add(novoUsuario);
                db.SaveChanges();
            }
        }

        public void AdicionarUsuarioPorObjeto(Usuario usuario)
        {
            var db = new CadeMeuMedicoDB();
            db.Usuarios.Add(usuario);
            db.SaveChanges();
        }

        public void AlterarDadosUsuarioPorObjeto(int id, Usuario usuario)
        {
            var db = new CadeMeuMedicoDB();
            var usuarioAlterado = db.Usuarios.Where(x => x.Id == id).FirstOrDefault();
            usuarioAlterado.Nome = usuario.Nome;
            usuarioAlterado.Email = usuario.Email;
            usuarioAlterado.ConfirmacaoEmail = usuario.ConfirmacaoEmail;
            usuarioAlterado.Senha = usuario.Senha;

            db.SaveChanges();
        }

        public void SimularPostAdicionarPorObjeto()
        {
            var usuarioNovo = new Usuario
            {
                Nome = "Marta",
                Email = "marta@marta.pt",
                ConfirmacaoEmail = "marta@marta.pt",
                Senha = CalculateMD5Hash("minahSenha0")
            };

            AdicionarUsuarioPorObjeto(usuarioNovo);
        }






        private string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public void AdicionarUsuarioEFalhaSeguranca(string nome, string email, string confirmacao, string senha)
        {
            //var db = new CadeMeuMedicoDB();
            //var novoUsuario = new Usuario

            var novoUsuario = new Usuario //criação do novo objecto usuario
            {
                Nome = nome,
                Email = email,
                ConfirmacaoEmail = confirmacao,
                Senha = CalculateMD5Hash(senha)
            };

            var db = new CadeMeuMedicoDB();
            // se encontrar um email igual, ou seja, o numero de emails iguais
            // for superior a 0, não adiciona o usuario
            /*if (db.Usuarios.Where(x => x.Email == email).Count() > 0) 
            {
                ///mensagem de erro
            }*/
            if (db.Usuarios.Any(x => x.Email == email))
            {
                ///mensagem de erro
            }
            else
            {
                db.DicionarioHash.Add(new DicionarioHash
                {
                    SenhaEmAberto = senha,
                    HashCriptografado = novoUsuario.Senha
                });


                db.Usuarios.Add(novoUsuario);
                db.SaveChanges();
            }
        }

    }
}