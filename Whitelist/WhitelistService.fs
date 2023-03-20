namespace White.Contracts.Whitelist

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes
open Nethereum.Web3
open Nethereum.RPC.Eth.DTOs
open Nethereum.Contracts.CQS
open Nethereum.Contracts.ContractHandlers
open Nethereum.Contracts
open System.Threading
open White.Contracts.Whitelist.ContractDefinition


    type WhitelistService (web3: Web3, contractAddress: string) =
    
        member val Web3 = web3 with get
        member val ContractHandler = web3.Eth.GetContractHandler(contractAddress) with get
    
        static member DeployContractAndWaitForReceiptAsync(web3: Web3, whitelistDeployment: WhitelistDeployment, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> = 
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            web3.Eth.GetContractDeploymentHandler<WhitelistDeployment>().SendRequestAndWaitForReceiptAsync(whitelistDeployment, cancellationTokenSourceVal)
        
        static member DeployContractAsync(web3: Web3, whitelistDeployment: WhitelistDeployment): Task<string> =
            web3.Eth.GetContractDeploymentHandler<WhitelistDeployment>().SendRequestAsync(whitelistDeployment)
        
        static member DeployContractAndGetServiceAsync(web3: Web3, whitelistDeployment: WhitelistDeployment, ?cancellationTokenSource : CancellationTokenSource) = async {
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            let! receipt = WhitelistService.DeployContractAndWaitForReceiptAsync(web3, whitelistDeployment, cancellationTokenSourceVal) |> Async.AwaitTask
            return new WhitelistService(web3, receipt.ContractAddress);
            }
    
        member this.AddRequestAsync(addFunction: AddFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(addFunction);
        
        member this.AddRequestAndWaitForReceiptAsync(addFunction: AddFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(addFunction, cancellationTokenSourceVal);
        
        member this.AddUserAddressToWhitelistRequestAsync(addUserAddressToWhitelistFunction: AddUserAddressToWhitelistFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(addUserAddressToWhitelistFunction);
        
        member this.AddUserAddressToWhitelistRequestAndWaitForReceiptAsync(addUserAddressToWhitelistFunction: AddUserAddressToWhitelistFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(addUserAddressToWhitelistFunction, cancellationTokenSourceVal);
        
        member this.GetMaxNumberOfWhitelistedAddressesQueryAsync(getMaxNumberOfWhitelistedAddressesFunction: GetMaxNumberOfWhitelistedAddressesFunction, ?blockParameter: BlockParameter): Task<BigInteger> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<GetMaxNumberOfWhitelistedAddressesFunction, BigInteger>(getMaxNumberOfWhitelistedAddressesFunction, blockParameterVal)
            
        member this.GetNumberOfWhitelistedAddressesQueryAsync(getNumberOfWhitelistedAddressesFunction: GetNumberOfWhitelistedAddressesFunction, ?blockParameter: BlockParameter): Task<BigInteger> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<GetNumberOfWhitelistedAddressesFunction, BigInteger>(getNumberOfWhitelistedAddressesFunction, blockParameterVal)
            
        member this.GetOwnerQueryAsync(getOwnerFunction: GetOwnerFunction, ?blockParameter: BlockParameter): Task<string> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<GetOwnerFunction, string>(getOwnerFunction, blockParameterVal)
            
        member this.MaxNumberOfWhitelistedAddressesQueryAsync(maxNumberOfWhitelistedAddressesFunction: MaxNumberOfWhitelistedAddressesFunction, ?blockParameter: BlockParameter): Task<BigInteger> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<MaxNumberOfWhitelistedAddressesFunction, BigInteger>(maxNumberOfWhitelistedAddressesFunction, blockParameterVal)
            
        member this.NumberOfAddressesWhitelistedQueryAsync(numberOfAddressesWhitelistedFunction: NumberOfAddressesWhitelistedFunction, ?blockParameter: BlockParameter): Task<BigInteger> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<NumberOfAddressesWhitelistedFunction, BigInteger>(numberOfAddressesWhitelistedFunction, blockParameterVal)
            
        member this.RemoveUserAddressFromWhitelistRequestAsync(removeUserAddressFromWhitelistFunction: RemoveUserAddressFromWhitelistFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(removeUserAddressFromWhitelistFunction);
        
        member this.RemoveUserAddressFromWhitelistRequestAndWaitForReceiptAsync(removeUserAddressFromWhitelistFunction: RemoveUserAddressFromWhitelistFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(removeUserAddressFromWhitelistFunction, cancellationTokenSourceVal);
        
        member this.VerifyQueryAsync(verifyFunction: VerifyFunction, ?blockParameter: BlockParameter): Task<BigInteger> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<VerifyFunction, BigInteger>(verifyFunction, blockParameterVal)
            
        member this.VerifyUserAddressQueryAsync(verifyUserAddressFunction: VerifyUserAddressFunction, ?blockParameter: BlockParameter): Task<bool> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<VerifyUserAddressFunction, bool>(verifyUserAddressFunction, blockParameterVal)
            
    

