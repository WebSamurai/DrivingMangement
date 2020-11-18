//using Microsoft.AspNetCore.Mvc.ModelBinding;
//using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace DriveDomain.ModelBinder
//{
//   public class ImageBinder : IModelBinder
//    {
//        public  async Task BindModelAsync(ModelBindingContext bindingContext)
//        {
//             //GetBinder(bindingContext);
//        }

//        public  GetBinder(ModelBindingContext context)
//        {
//            if (context == null)
//            {
//                throw new ArgumentNullException(nameof(context));
//            }

//            if (context.ModelType== typeof(byte[]))
//            {
//                 new ByteArrayModelBinder().BindModelAsync();
//            }

//            return null;
//        }
//    }
//}
