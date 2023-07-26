using Application.Interfaces;
using Domain.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.App
{
    public class App<TViewModel, TModel> : IApp<TViewModel, TModel>

     where TViewModel : class

     where TModel : class

    {

        protected readonly ILogger<App<TViewModel, TModel>> _logger;


        protected readonly IRepository<TModel> _repository;



        public App(ILogger<App<TViewModel, TModel>> logger,

        IRepository<TModel> repository)

        {

            _logger = logger;

            _repository = repository;

        }
    }
}
