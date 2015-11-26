namespace VeriBank.Business.Transactions {
    export interface ITransaction extends IStart, IFetch, IConfirm, IExecute {
    }

    interface IStart {
        Start: (request: cm.RequestMessage, response: cm.ResponseMessage) => void;
    }

    interface IFetch {
        Fetch: (request: cm.RequestMessage, response: cm.ResponseMessage) => void;
    }

    interface IConfirm {
        Confirm: (request: cm.RequestMessage, response: cm.ResponseMessage) => void;
    }

    interface IExecute {
        Execute: (request: cm.RequestMessage, response: cm.ResponseMessage) => void;
    }
}