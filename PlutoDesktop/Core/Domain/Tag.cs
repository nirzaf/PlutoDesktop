using System.Collections.ObjectModel;

namespace PlutoDesktop.Core.Domain
{
    public class Tag
    {
        public Tag()
        {
            Courses = new ObservableCollection<Course>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ObservableCollection<Course> Courses { get; set; }
    }
}
