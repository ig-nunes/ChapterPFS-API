using ChapterPFS.Models;

namespace ChapterPFS.Interfaces
{
    public interface IUsuarioRepository
    {
        List<Usuario> Listar();

        Usuario BuscarPorId(int id);

        void Cadastrar(Usuario usuario);

        void Atualizar(int id, Usuario usuario);

        void Deletar(int id);

        //Método de Login
        Usuario Login(string email, string senha);
    }
}
