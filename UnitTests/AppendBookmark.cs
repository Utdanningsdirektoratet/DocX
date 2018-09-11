using Xunit;
using Novacode;
using System.Linq;

namespace UnitTests
{
    public class AppendBookmark
    {
        [Fact]
        public void Bookmark_should_be_appended()
        {
            using (var doc = DocX.Create(""))
            {
                var paragraph = doc.InsertParagraph("A paragraph");
                paragraph.AppendBookmark("bookmark");
                var bookmarks = paragraph.GetBookmarks();
                Assert.Equal(1, bookmarks.Count());
            }
        }

        [Fact]
        public void Bookmark_should_be_named_correctly()
        {
            using (var doc = DocX.Create(""))
            {
                var paragraph = doc.InsertParagraph("A paragraph");
                paragraph.AppendBookmark("bookmark");
                var bookmarks = paragraph.GetBookmarks();
                Assert.Equal("bookmark", bookmarks.First().Name);
            }
        }

        [Fact]
        public void Bookmark_should_reference_paragraph()
        {
            using (var doc = DocX.Create(""))
            {
                var paragraph = doc.InsertParagraph("A paragraph");
                paragraph.AppendBookmark("bookmark");
                var bookmarks = paragraph.GetBookmarks();
                Assert.Equal(paragraph, bookmarks.First().Paragraph);
            }
        }

    }
}
