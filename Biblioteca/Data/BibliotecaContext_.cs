using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Data
{
	public class BibliotecaContext_: DbContext
	{
		public BibliotecaContext_(DbContextOptions<BibliotecaContext_> options) : base(options)
		{ 
		
		}

	}
}
