		using System;
		using System.Collections.Generic;
		using System.Text;
		using Dominio_dsmGen.ApplicationCore.Utils;
		using Microsoft.Extensions.DependencyInjection;
			
		namespace Dominio_dsmGen.Infraestructure.Utils
		{
    		public class UnitOfWorkUtils : GenericUnitOfWorkUtils
			{
			    ServiceCollection serviceDescriptors;
			    ServiceProvider serviceProvider;
			
			
			    public UnitOfWorkUtils()
			    {
			        serviceDescriptors = new ServiceCollection();
			
			      /*  serviceDescriptors.AddScoped<IClientInvoicePDF, ClientInvoicePDF>();
			
			        serviceDescriptors.AddScoped<ITicketDetail, TicketDetailPDF>();*/
			
			        serviceProvider = serviceDescriptors.BuildServiceProvider();
			
			
			    }
			   /* public override IClientInvoicePDF ClientInvoicePDF
			    {
			        get
			        {         
			                return serviceProvider.GetService<IClientInvoicePDF>();
			        }
			    } 
			
			    public override ITicketDetail TickedDetail
			    {
			        get
			        {
			                return serviceProvider.GetService<ITicketDetail>();
			        }
			    } */
			}
		}
		
