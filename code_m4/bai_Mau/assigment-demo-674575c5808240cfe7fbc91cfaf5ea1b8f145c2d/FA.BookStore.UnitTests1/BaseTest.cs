using FA.BookStore.Core.Repository.IRepository;
using FA.BookStore.Core.Repository.UnitOfWork;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.UnitTests1
{
    public class BaseTest
    {
        protected IUnitOfWork uow;
        protected IBookRepository bookRepository;

        protected Mock<IUnitOfWork> uowMock;
        protected Mock<IBookRepository> bookRepsitoryMock;

        public BaseTest()
        {
            uowMock = new Mock<IUnitOfWork>();
            bookRepsitoryMock = new Mock<IBookRepository>();
        }


    }
}
