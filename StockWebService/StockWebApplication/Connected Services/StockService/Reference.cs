﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockWebApplication.StockService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StockService.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since the wrapper name (Hello) of message Hello does not match the default value (HelloWorld)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Hello", ReplyAction="*")]
        StockWebApplication.StockService.Hello1 HelloWorld(StockWebApplication.StockService.Hello request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Hello", ReplyAction="*")]
        System.Threading.Tasks.Task<StockWebApplication.StockService.Hello1> HelloWorldAsync(StockWebApplication.StockService.Hello request);
        
        // CODEGEN: Generating message contract since the wrapper name (For_x0020_the_x0020_sum_x0020_of_x0020_two_x0020_numbers) of message For_x0020_the_x0020_sum_x0020_of_x0020_two_x0020_numbers does not match the default value (Addition)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/For the sum of two numbers", ReplyAction="*")]
        StockWebApplication.StockService.Forthesumoftwonumbers1 Addition(StockWebApplication.StockService.Forthesumoftwonumbers request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/For the sum of two numbers", ReplyAction="*")]
        System.Threading.Tasks.Task<StockWebApplication.StockService.Forthesumoftwonumbers1> AdditionAsync(StockWebApplication.StockService.Forthesumoftwonumbers request);
        
        // CODEGEN: Generating message contract since the wrapper name (For_x0020_the_x0020_difference_x0020_of_x0020_two_x0020_numbers) of message For_x0020_the_x0020_difference_x0020_of_x0020_two_x0020_numbers does not match the default value (Subraction)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/For the difference of two numbers", ReplyAction="*")]
        StockWebApplication.StockService.Forthedifferenceoftwonumbers1 Subraction(StockWebApplication.StockService.Forthedifferenceoftwonumbers request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/For the difference of two numbers", ReplyAction="*")]
        System.Threading.Tasks.Task<StockWebApplication.StockService.Forthedifferenceoftwonumbers1> SubractionAsync(StockWebApplication.StockService.Forthedifferenceoftwonumbers request);
        
        // CODEGEN: Generating message contract since the wrapper name (For_x0020_the_x0020_product_x0020_of_x0020_two_x0020_numbers) of message For_x0020_the_x0020_product_x0020_of_x0020_two_x0020_numbers does not match the default value (Multiplication)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/For the product of two numbers", ReplyAction="*")]
        StockWebApplication.StockService.Fortheproductoftwonumbers1 Multiplication(StockWebApplication.StockService.Fortheproductoftwonumbers request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/For the product of two numbers", ReplyAction="*")]
        System.Threading.Tasks.Task<StockWebApplication.StockService.Fortheproductoftwonumbers1> MultiplicationAsync(StockWebApplication.StockService.Fortheproductoftwonumbers request);
        
        // CODEGEN: Generating message contract since the wrapper name (For_x0020_the_x0020_division_x0020_of_x0020_two_x0020_numbers) of message For_x0020_the_x0020_division_x0020_of_x0020_two_x0020_numbers does not match the default value (Division)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/For the division of two numbers", ReplyAction="*")]
        StockWebApplication.StockService.Forthedivisionoftwonumbers1 Division(StockWebApplication.StockService.Forthedivisionoftwonumbers request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/For the division of two numbers", ReplyAction="*")]
        System.Threading.Tasks.Task<StockWebApplication.StockService.Forthedivisionoftwonumbers1> DivisionAsync(StockWebApplication.StockService.Forthedivisionoftwonumbers request);
        
        // CODEGEN: Generating message contract since the wrapper name (For_x0020_getting_x0020_the_x0020_user_x0027_s_x0020_nameInitial_x0020_by_x0020_writing_x0020_her_x0020_initial) of message For_x0020_getting_x0020_the_x0020_user_x0027_s_x0020_nameInitial_x0020_by_x0020_writing_x0020_her_x0020_initial does not match the default value (GetName)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/For getting the user\'s nameInitial by writing her initial", ReplyAction="*")]
        StockWebApplication.StockService.ForgettingtheusersnameInitialbywritingherinitial1 GetName(StockWebApplication.StockService.ForgettingtheusersnameInitialbywritingherinitial request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/For getting the user\'s nameInitial by writing her initial", ReplyAction="*")]
        System.Threading.Tasks.Task<StockWebApplication.StockService.ForgettingtheusersnameInitialbywritingherinitial1> GetNameAsync(StockWebApplication.StockService.ForgettingtheusersnameInitialbywritingherinitial request);
        
        // CODEGEN: Generating message contract since the wrapper name (For_x0020_getting_x0020_the_x0020_birth_x0020_date) of message For_x0020_getting_x0020_the_x0020_birth_x0020_date does not match the default value (GetBirthDate)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/For getting the birth date", ReplyAction="*")]
        StockWebApplication.StockService.Forgettingthebirthdate1 GetBirthDate(StockWebApplication.StockService.Forgettingthebirthdate request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/For getting the birth date", ReplyAction="*")]
        System.Threading.Tasks.Task<StockWebApplication.StockService.Forgettingthebirthdate1> GetBirthDateAsync(StockWebApplication.StockService.Forgettingthebirthdate request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Hello", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Hello {
        
        public Hello() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HelloResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Hello1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string HelloResult;
        
        public Hello1() {
        }
        
        public Hello1(string HelloResult) {
            this.HelloResult = HelloResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="For the sum of two numbers", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Forthesumoftwonumbers {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int x;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int y;
        
        public Forthesumoftwonumbers() {
        }
        
        public Forthesumoftwonumbers(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="For the sum of two numbersResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Forthesumoftwonumbers1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="For_x0020_the_x0020_sum_x0020_of_x0020_two_x0020_numbersResult", Namespace="http://tempuri.org/", Order=0)]
        public int ForthesumoftwonumbersResult;
        
        public Forthesumoftwonumbers1() {
        }
        
        public Forthesumoftwonumbers1(int ForthesumoftwonumbersResult) {
            this.ForthesumoftwonumbersResult = ForthesumoftwonumbersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="For the difference of two numbers", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Forthedifferenceoftwonumbers {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int x;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int y;
        
        public Forthedifferenceoftwonumbers() {
        }
        
        public Forthedifferenceoftwonumbers(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="For the difference of two numbersResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Forthedifferenceoftwonumbers1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="For_x0020_the_x0020_difference_x0020_of_x0020_two_x0020_numbersResult", Namespace="http://tempuri.org/", Order=0)]
        public int ForthedifferenceoftwonumbersResult;
        
        public Forthedifferenceoftwonumbers1() {
        }
        
        public Forthedifferenceoftwonumbers1(int ForthedifferenceoftwonumbersResult) {
            this.ForthedifferenceoftwonumbersResult = ForthedifferenceoftwonumbersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="For the product of two numbers", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Fortheproductoftwonumbers {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int x;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int y;
        
        public Fortheproductoftwonumbers() {
        }
        
        public Fortheproductoftwonumbers(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="For the product of two numbersResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Fortheproductoftwonumbers1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="For_x0020_the_x0020_product_x0020_of_x0020_two_x0020_numbersResult", Namespace="http://tempuri.org/", Order=0)]
        public int FortheproductoftwonumbersResult;
        
        public Fortheproductoftwonumbers1() {
        }
        
        public Fortheproductoftwonumbers1(int FortheproductoftwonumbersResult) {
            this.FortheproductoftwonumbersResult = FortheproductoftwonumbersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="For the division of two numbers", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Forthedivisionoftwonumbers {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int x;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int y;
        
        public Forthedivisionoftwonumbers() {
        }
        
        public Forthedivisionoftwonumbers(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="For the division of two numbersResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Forthedivisionoftwonumbers1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="For_x0020_the_x0020_division_x0020_of_x0020_two_x0020_numbersResult", Namespace="http://tempuri.org/", Order=0)]
        public int ForthedivisionoftwonumbersResult;
        
        public Forthedivisionoftwonumbers1() {
        }
        
        public Forthedivisionoftwonumbers1(int ForthedivisionoftwonumbersResult) {
            this.ForthedivisionoftwonumbersResult = ForthedivisionoftwonumbersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="For getting the user\'s nameInitial by writing her initial", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ForgettingtheusersnameInitialbywritingherinitial {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public char nameInitial;
        
        public ForgettingtheusersnameInitialbywritingherinitial() {
        }
        
        public ForgettingtheusersnameInitialbywritingherinitial(char nameInitial) {
            this.nameInitial = nameInitial;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="For getting the user\'s nameInitial by writing her initialResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ForgettingtheusersnameInitialbywritingherinitial1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="For_x0020_getting_x0020_the_x0020_user_x0027_s_x0020_nameInitial_x0020_by_x0020_w" +
            "riting_x0020_her_x0020_initialResult", Namespace="http://tempuri.org/", Order=0)]
        public string ForgettingtheusersnameInitialbywritingherinitialResult;
        
        public ForgettingtheusersnameInitialbywritingherinitial1() {
        }
        
        public ForgettingtheusersnameInitialbywritingherinitial1(string ForgettingtheusersnameInitialbywritingherinitialResult) {
            this.ForgettingtheusersnameInitialbywritingherinitialResult = ForgettingtheusersnameInitialbywritingherinitialResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="For getting the birth date", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Forgettingthebirthdate {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string symbol;
        
        public Forgettingthebirthdate() {
        }
        
        public Forgettingthebirthdate(string symbol) {
            this.symbol = symbol;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="For getting the birth dateResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Forgettingthebirthdate1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="For_x0020_getting_x0020_the_x0020_birth_x0020_dateResult", Namespace="http://tempuri.org/", Order=0)]
        public System.DateTime ForgettingthebirthdateResult;
        
        public Forgettingthebirthdate1() {
        }
        
        public Forgettingthebirthdate1(System.DateTime ForgettingthebirthdateResult) {
            this.ForgettingthebirthdateResult = ForgettingthebirthdateResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : StockWebApplication.StockService.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<StockWebApplication.StockService.WebService1Soap>, StockWebApplication.StockService.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        StockWebApplication.StockService.Hello1 StockWebApplication.StockService.WebService1Soap.HelloWorld(StockWebApplication.StockService.Hello request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            StockWebApplication.StockService.Hello inValue = new StockWebApplication.StockService.Hello();
            StockWebApplication.StockService.Hello1 retVal = ((StockWebApplication.StockService.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.HelloResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<StockWebApplication.StockService.Hello1> StockWebApplication.StockService.WebService1Soap.HelloWorldAsync(StockWebApplication.StockService.Hello request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<StockWebApplication.StockService.Hello1> HelloWorldAsync() {
            StockWebApplication.StockService.Hello inValue = new StockWebApplication.StockService.Hello();
            return ((StockWebApplication.StockService.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        StockWebApplication.StockService.Forthesumoftwonumbers1 StockWebApplication.StockService.WebService1Soap.Addition(StockWebApplication.StockService.Forthesumoftwonumbers request) {
            return base.Channel.Addition(request);
        }
        
        public int Addition(int x, int y) {
            StockWebApplication.StockService.Forthesumoftwonumbers inValue = new StockWebApplication.StockService.Forthesumoftwonumbers();
            inValue.x = x;
            inValue.y = y;
            StockWebApplication.StockService.Forthesumoftwonumbers1 retVal = ((StockWebApplication.StockService.WebService1Soap)(this)).Addition(inValue);
            return retVal.ForthesumoftwonumbersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<StockWebApplication.StockService.Forthesumoftwonumbers1> StockWebApplication.StockService.WebService1Soap.AdditionAsync(StockWebApplication.StockService.Forthesumoftwonumbers request) {
            return base.Channel.AdditionAsync(request);
        }
        
        public System.Threading.Tasks.Task<StockWebApplication.StockService.Forthesumoftwonumbers1> AdditionAsync(int x, int y) {
            StockWebApplication.StockService.Forthesumoftwonumbers inValue = new StockWebApplication.StockService.Forthesumoftwonumbers();
            inValue.x = x;
            inValue.y = y;
            return ((StockWebApplication.StockService.WebService1Soap)(this)).AdditionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        StockWebApplication.StockService.Forthedifferenceoftwonumbers1 StockWebApplication.StockService.WebService1Soap.Subraction(StockWebApplication.StockService.Forthedifferenceoftwonumbers request) {
            return base.Channel.Subraction(request);
        }
        
        public int Subraction(int x, int y) {
            StockWebApplication.StockService.Forthedifferenceoftwonumbers inValue = new StockWebApplication.StockService.Forthedifferenceoftwonumbers();
            inValue.x = x;
            inValue.y = y;
            StockWebApplication.StockService.Forthedifferenceoftwonumbers1 retVal = ((StockWebApplication.StockService.WebService1Soap)(this)).Subraction(inValue);
            return retVal.ForthedifferenceoftwonumbersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<StockWebApplication.StockService.Forthedifferenceoftwonumbers1> StockWebApplication.StockService.WebService1Soap.SubractionAsync(StockWebApplication.StockService.Forthedifferenceoftwonumbers request) {
            return base.Channel.SubractionAsync(request);
        }
        
        public System.Threading.Tasks.Task<StockWebApplication.StockService.Forthedifferenceoftwonumbers1> SubractionAsync(int x, int y) {
            StockWebApplication.StockService.Forthedifferenceoftwonumbers inValue = new StockWebApplication.StockService.Forthedifferenceoftwonumbers();
            inValue.x = x;
            inValue.y = y;
            return ((StockWebApplication.StockService.WebService1Soap)(this)).SubractionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        StockWebApplication.StockService.Fortheproductoftwonumbers1 StockWebApplication.StockService.WebService1Soap.Multiplication(StockWebApplication.StockService.Fortheproductoftwonumbers request) {
            return base.Channel.Multiplication(request);
        }
        
        public int Multiplication(int x, int y) {
            StockWebApplication.StockService.Fortheproductoftwonumbers inValue = new StockWebApplication.StockService.Fortheproductoftwonumbers();
            inValue.x = x;
            inValue.y = y;
            StockWebApplication.StockService.Fortheproductoftwonumbers1 retVal = ((StockWebApplication.StockService.WebService1Soap)(this)).Multiplication(inValue);
            return retVal.FortheproductoftwonumbersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<StockWebApplication.StockService.Fortheproductoftwonumbers1> StockWebApplication.StockService.WebService1Soap.MultiplicationAsync(StockWebApplication.StockService.Fortheproductoftwonumbers request) {
            return base.Channel.MultiplicationAsync(request);
        }
        
        public System.Threading.Tasks.Task<StockWebApplication.StockService.Fortheproductoftwonumbers1> MultiplicationAsync(int x, int y) {
            StockWebApplication.StockService.Fortheproductoftwonumbers inValue = new StockWebApplication.StockService.Fortheproductoftwonumbers();
            inValue.x = x;
            inValue.y = y;
            return ((StockWebApplication.StockService.WebService1Soap)(this)).MultiplicationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        StockWebApplication.StockService.Forthedivisionoftwonumbers1 StockWebApplication.StockService.WebService1Soap.Division(StockWebApplication.StockService.Forthedivisionoftwonumbers request) {
            return base.Channel.Division(request);
        }
        
        public int Division(int x, int y) {
            StockWebApplication.StockService.Forthedivisionoftwonumbers inValue = new StockWebApplication.StockService.Forthedivisionoftwonumbers();
            inValue.x = x;
            inValue.y = y;
            StockWebApplication.StockService.Forthedivisionoftwonumbers1 retVal = ((StockWebApplication.StockService.WebService1Soap)(this)).Division(inValue);
            return retVal.ForthedivisionoftwonumbersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<StockWebApplication.StockService.Forthedivisionoftwonumbers1> StockWebApplication.StockService.WebService1Soap.DivisionAsync(StockWebApplication.StockService.Forthedivisionoftwonumbers request) {
            return base.Channel.DivisionAsync(request);
        }
        
        public System.Threading.Tasks.Task<StockWebApplication.StockService.Forthedivisionoftwonumbers1> DivisionAsync(int x, int y) {
            StockWebApplication.StockService.Forthedivisionoftwonumbers inValue = new StockWebApplication.StockService.Forthedivisionoftwonumbers();
            inValue.x = x;
            inValue.y = y;
            return ((StockWebApplication.StockService.WebService1Soap)(this)).DivisionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        StockWebApplication.StockService.ForgettingtheusersnameInitialbywritingherinitial1 StockWebApplication.StockService.WebService1Soap.GetName(StockWebApplication.StockService.ForgettingtheusersnameInitialbywritingherinitial request) {
            return base.Channel.GetName(request);
        }
        
        public string GetName(char nameInitial) {
            StockWebApplication.StockService.ForgettingtheusersnameInitialbywritingherinitial inValue = new StockWebApplication.StockService.ForgettingtheusersnameInitialbywritingherinitial();
            inValue.nameInitial = nameInitial;
            StockWebApplication.StockService.ForgettingtheusersnameInitialbywritingherinitial1 retVal = ((StockWebApplication.StockService.WebService1Soap)(this)).GetName(inValue);
            return retVal.ForgettingtheusersnameInitialbywritingherinitialResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<StockWebApplication.StockService.ForgettingtheusersnameInitialbywritingherinitial1> StockWebApplication.StockService.WebService1Soap.GetNameAsync(StockWebApplication.StockService.ForgettingtheusersnameInitialbywritingherinitial request) {
            return base.Channel.GetNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<StockWebApplication.StockService.ForgettingtheusersnameInitialbywritingherinitial1> GetNameAsync(char nameInitial) {
            StockWebApplication.StockService.ForgettingtheusersnameInitialbywritingherinitial inValue = new StockWebApplication.StockService.ForgettingtheusersnameInitialbywritingherinitial();
            inValue.nameInitial = nameInitial;
            return ((StockWebApplication.StockService.WebService1Soap)(this)).GetNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        StockWebApplication.StockService.Forgettingthebirthdate1 StockWebApplication.StockService.WebService1Soap.GetBirthDate(StockWebApplication.StockService.Forgettingthebirthdate request) {
            return base.Channel.GetBirthDate(request);
        }
        
        public System.DateTime GetBirthDate(string symbol) {
            StockWebApplication.StockService.Forgettingthebirthdate inValue = new StockWebApplication.StockService.Forgettingthebirthdate();
            inValue.symbol = symbol;
            StockWebApplication.StockService.Forgettingthebirthdate1 retVal = ((StockWebApplication.StockService.WebService1Soap)(this)).GetBirthDate(inValue);
            return retVal.ForgettingthebirthdateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<StockWebApplication.StockService.Forgettingthebirthdate1> StockWebApplication.StockService.WebService1Soap.GetBirthDateAsync(StockWebApplication.StockService.Forgettingthebirthdate request) {
            return base.Channel.GetBirthDateAsync(request);
        }
        
        public System.Threading.Tasks.Task<StockWebApplication.StockService.Forgettingthebirthdate1> GetBirthDateAsync(string symbol) {
            StockWebApplication.StockService.Forgettingthebirthdate inValue = new StockWebApplication.StockService.Forgettingthebirthdate();
            inValue.symbol = symbol;
            return ((StockWebApplication.StockService.WebService1Soap)(this)).GetBirthDateAsync(inValue);
        }
    }
}
