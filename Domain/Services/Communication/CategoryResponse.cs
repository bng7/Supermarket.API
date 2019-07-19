using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Services.Communication
{
  public class CategoryResponse : BaseResponse
  {
    public Category Category { get; set; }

    private CategoryResponse(bool success, string message, Category category) : base(success, message)
    {
      Category = category;
    }

    /// <summer>
    /// Create a success response.
    /// </summer>
    /// <param name="category">Saved category.</param>
    /// <returns>Response.</returns>
    public CategoryResponse(Category category) : this(true, string.Empty, category)
    {}

    /// <summary>
    /// Creates an error response.
    /// </summary>
    /// <param name="message">Error message.</param>
    /// <returns>Response.</returns>
    public CategoryResponse(string message) : this(false, message, null)
    { }
  }
}