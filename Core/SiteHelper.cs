using Markdig;
using Microsoft.AspNetCore.Components;

namespace Core;

public static class SiteHelper
{
    /// <summary>
    /// Converts the given Markdown content to HTML.
    /// </summary>
    /// <param name="content">The Markdown content to convert.</param>
    /// <returns>The HTML markup string.</returns>
    public static MarkupString MarkdownToHtml(this string content)
    {
        if (!string.IsNullOrEmpty(content))
        {
            var pipeline = new MarkdownPipelineBuilder()
                .DisableHtml()
                .Build();

            return (MarkupString)Markdown.ToHtml(content, pipeline);
        }
        else
            return (MarkupString)string.Empty;
    }

}

