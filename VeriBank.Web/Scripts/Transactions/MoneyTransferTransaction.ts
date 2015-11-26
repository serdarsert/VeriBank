namespace VeriBank.Business.Transactions.MoneyTransfer {
    interface ITransaction {
        Start: (request: cm.RequestMessage, response: cm.ResponseMessage) => void;
        Fetch: (request: cm.RequestMessage, response: cm.ResponseMessage) => void;
        Confirm: (request: cm.RequestMessage, response: cm.ResponseMessage) => void;
        Execute: (request: cm.RequestMessage, response: cm.ResponseMessage) => void;
    }

    export class MoneyTransferTransaction implements ITransaction {
        Start(request: cm.RequestMessage, response: cm.ResponseMessage) {

        }
        Fetch(request: cm.RequestMessage, response: cm.ResponseMessage) {

        }
        Confirm(request: cm.RequestMessage, response: cm.ResponseMessage) {

        }
        Execute(request: cm.RequestMessage, response: cm.ResponseMessage) {

        }
    }
}