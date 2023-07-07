namespace Blog.Business.DtoData;

public class NavbarDto
{
	public IEnumerable<CategoryDto> Categories { get; set; }
	public List<PageDto> Pages { get; set; }
}
