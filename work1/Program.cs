//Kodlama.io ana sayfasında bulunan Course, Category, Instructor nesnelerini modelleyiniz.
//İlişkileri kurunuz. Tüm CRUD operasyonlarını katmanlı yapıda simüle ediniz. Github kodlarınızı paylaşınız.

using System.ComponentModel;
using work1.Entities;

List<Category> categories = new List<Category>();
categories.Add(new Category()
{
	Id = 1,
	Name = "Programlama",
});
List<Instructor> instructors = new List<Instructor>()
{

	new Instructor()
	{
		Id = 1,
		FirstName="Engin",
		LastName="Demiroğ"
	},
	new Instructor()
	{
		Id=2,
		FirstName="Halit Enes",
		LastName="Kalaycı"
	}
};