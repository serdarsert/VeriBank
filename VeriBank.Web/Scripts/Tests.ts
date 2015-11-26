import cm = VeriBank.CommonMessages;
import mt = VeriBank.Business.Transactions.MoneyTransfer;
class TestApp {
    static Test() {
        var sourceAccount = new cm.Account(200);
        sourceAccount.increaseBalance(20);
        sourceAccount.getBalance();
        sourceAccount.Balance = 20;
        var destinationAccount = new cm.Account(150);
        destinationAccount.increaseBalance(10);

        console.log(sourceAccount);
        console.log(destinationAccount);

        var customer = new cm.Customer();
        customer.CustomerType = cm.CustomerTypeEnum.Retail;
        customer.Name = "Serdar";
        customer.LastName = "Sert";
        customer.No = 1;

        console.log(customer);


        var request: cm.RequestMessage = new cm.RequestMessage();
        request.TransactionHeader = new cm.TransactionHeader();
        request.TransactionHeader.Customer = customer;
        var response: cm.ResponseMessage = new cm.ResponseMessage();
        console.log(request);
        console.log(response);
        console.log("MoneyTransfer transaction is starting...");
        var transaction = new mt.MoneyTransferTransaction();
        transaction.Start(request, response);
        console.log("MoneyTransfer transaction started.");
        console.log(response);

        var accountList = new collections.Dictionary<string, cm.Account>();
        accountList.setValue("Hesap 1", sourceAccount);
        accountList.setValue("Hesap 2", destinationAccount);
        console.log(accountList);
    }
}