using Blog.Business.Services;
using Blog.Business.Services.Abstract;
using Blog.Business.DtoData;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Mvc.ViewComponents;

public class NavbarViewComponent : ViewComponent
{
    private readonly ICategoryService _cs;
    private readonly PageService _pageService;

    public NavbarViewComponent(CategoryService cs, PageService pageService)
    {
        _cs = cs;
        _pageService = pageService;
    }

    public Task<IViewComponentResult> InvokeAsync()
    {
        return Task.FromResult<IViewComponentResult>(View(
            new NavbarDto
            {
                Categories = _cs.GetAll(),
                Pages = _pageService.GetAll()
            }));
    }
}
