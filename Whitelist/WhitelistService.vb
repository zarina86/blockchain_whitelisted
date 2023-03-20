Imports System
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Numerics
Imports Nethereum.Hex.HexTypes
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports Nethereum.Web3
Imports Nethereum.RPC.Eth.DTOs
Imports Nethereum.Contracts.CQS
Imports Nethereum.Contracts.ContractHandlers
Imports Nethereum.Contracts
Imports System.Threading
Imports White.Contracts.Whitelist.ContractDefinition
Namespace White.Contracts.Whitelist


    Public Partial Class WhitelistService
    
    
        Public Shared Function DeployContractAndWaitForReceiptAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal whitelistDeployment As WhitelistDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return web3.Eth.GetContractDeploymentHandler(Of WhitelistDeployment)().SendRequestAndWaitForReceiptAsync(whitelistDeployment, cancellationTokenSource)
        
        End Function
         Public Shared Function DeployContractAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal whitelistDeployment As WhitelistDeployment) As Task(Of String)
        
            Return web3.Eth.GetContractDeploymentHandler(Of WhitelistDeployment)().SendRequestAsync(whitelistDeployment)
        
        End Function
        Public Shared Async Function DeployContractAndGetServiceAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal whitelistDeployment As WhitelistDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of WhitelistService)
        
            Dim receipt = Await DeployContractAndWaitForReceiptAsync(web3, whitelistDeployment, cancellationTokenSource)
            Return New WhitelistService(web3, receipt.ContractAddress)
        
        End Function
    
        Protected Property Web3 As Nethereum.Web3.Web3
        
        Public Property ContractHandler As ContractHandler
        
        Public Sub New(ByVal web3 As Nethereum.Web3.Web3, ByVal contractAddress As String)
            Web3 = web3
            ContractHandler = web3.Eth.GetContractHandler(contractAddress)
        End Sub
    
        Public Function AddUserAddressToWhitelistRequestAsync(ByVal addUserAddressToWhitelistFunction As AddUserAddressToWhitelistFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of AddUserAddressToWhitelistFunction)(addUserAddressToWhitelistFunction)
        
        End Function

        Public Function AddUserAddressToWhitelistRequestAndWaitForReceiptAsync(ByVal addUserAddressToWhitelistFunction As AddUserAddressToWhitelistFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of AddUserAddressToWhitelistFunction)(addUserAddressToWhitelistFunction, cancellationToken)
        
        End Function

        
        Public Function AddUserAddressToWhitelistRequestAsync(ByVal [addressToWhitelist] As String) As Task(Of String)
        
            Dim addUserAddressToWhitelistFunction = New AddUserAddressToWhitelistFunction()
                addUserAddressToWhitelistFunction.AddressToWhitelist = [addressToWhitelist]
            
            Return ContractHandler.SendRequestAsync(Of AddUserAddressToWhitelistFunction)(addUserAddressToWhitelistFunction)
        
        End Function

        
        Public Function AddUserAddressToWhitelistRequestAndWaitForReceiptAsync(ByVal [addressToWhitelist] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim addUserAddressToWhitelistFunction = New AddUserAddressToWhitelistFunction()
                addUserAddressToWhitelistFunction.AddressToWhitelist = [addressToWhitelist]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of AddUserAddressToWhitelistFunction)(addUserAddressToWhitelistFunction, cancellationToken)
        
        End Function
        Public Function GetMaxNumberOfWhitelistedAddressesQueryAsync(ByVal getMaxNumberOfWhitelistedAddressesFunction As GetMaxNumberOfWhitelistedAddressesFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of GetMaxNumberOfWhitelistedAddressesFunction, BigInteger)(getMaxNumberOfWhitelistedAddressesFunction, blockParameter)
        
        End Function

        
        Public Function GetMaxNumberOfWhitelistedAddressesQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of GetMaxNumberOfWhitelistedAddressesFunction, BigInteger)(Nothing, blockParameter)
        
        End Function



        Public Function GetNumberOfWhitelistedAddressesQueryAsync(ByVal getNumberOfWhitelistedAddressesFunction As GetNumberOfWhitelistedAddressesFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of GetNumberOfWhitelistedAddressesFunction, BigInteger)(getNumberOfWhitelistedAddressesFunction, blockParameter)
        
        End Function

        
        Public Function GetNumberOfWhitelistedAddressesQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of GetNumberOfWhitelistedAddressesFunction, BigInteger)(Nothing, blockParameter)
        
        End Function



        Public Function GetOwnerQueryAsync(ByVal getOwnerFunction As GetOwnerFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of GetOwnerFunction, String)(getOwnerFunction, blockParameter)
        
        End Function

        
        Public Function GetOwnerQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of GetOwnerFunction, String)(Nothing, blockParameter)
        
        End Function



        Public Function IsWhitelistedQueryAsync(ByVal isWhitelistedFunction As IsWhitelistedFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Boolean)
        
            Return ContractHandler.QueryAsync(Of IsWhitelistedFunction, Boolean)(isWhitelistedFunction, blockParameter)
        
        End Function

        
        Public Function IsWhitelistedQueryAsync(ByVal [whitelistedAddress] As String, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Boolean)
        
            Dim isWhitelistedFunction = New IsWhitelistedFunction()
                isWhitelistedFunction.WhitelistedAddress = [whitelistedAddress]
            
            Return ContractHandler.QueryAsync(Of IsWhitelistedFunction, Boolean)(isWhitelistedFunction, blockParameter)
        
        End Function


        Public Function MaxNumberOfWhitelistedAddressesQueryAsync(ByVal maxNumberOfWhitelistedAddressesFunction As MaxNumberOfWhitelistedAddressesFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of MaxNumberOfWhitelistedAddressesFunction, BigInteger)(maxNumberOfWhitelistedAddressesFunction, blockParameter)
        
        End Function

        
        Public Function MaxNumberOfWhitelistedAddressesQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of MaxNumberOfWhitelistedAddressesFunction, BigInteger)(Nothing, blockParameter)
        
        End Function



        Public Function NumberOfAddressesWhitelistedQueryAsync(ByVal numberOfAddressesWhitelistedFunction As NumberOfAddressesWhitelistedFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of NumberOfAddressesWhitelistedFunction, BigInteger)(numberOfAddressesWhitelistedFunction, blockParameter)
        
        End Function

        
        Public Function NumberOfAddressesWhitelistedQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of NumberOfAddressesWhitelistedFunction, BigInteger)(Nothing, blockParameter)
        
        End Function



        Public Function RemoveUserAddressFromWhitelistRequestAsync(ByVal removeUserAddressFromWhitelistFunction As RemoveUserAddressFromWhitelistFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of RemoveUserAddressFromWhitelistFunction)(removeUserAddressFromWhitelistFunction)
        
        End Function

        Public Function RemoveUserAddressFromWhitelistRequestAndWaitForReceiptAsync(ByVal removeUserAddressFromWhitelistFunction As RemoveUserAddressFromWhitelistFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of RemoveUserAddressFromWhitelistFunction)(removeUserAddressFromWhitelistFunction, cancellationToken)
        
        End Function

        
        Public Function RemoveUserAddressFromWhitelistRequestAsync(ByVal [addressToRemove] As String) As Task(Of String)
        
            Dim removeUserAddressFromWhitelistFunction = New RemoveUserAddressFromWhitelistFunction()
                removeUserAddressFromWhitelistFunction.AddressToRemove = [addressToRemove]
            
            Return ContractHandler.SendRequestAsync(Of RemoveUserAddressFromWhitelistFunction)(removeUserAddressFromWhitelistFunction)
        
        End Function

        
        Public Function RemoveUserAddressFromWhitelistRequestAndWaitForReceiptAsync(ByVal [addressToRemove] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim removeUserAddressFromWhitelistFunction = New RemoveUserAddressFromWhitelistFunction()
                removeUserAddressFromWhitelistFunction.AddressToRemove = [addressToRemove]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of RemoveUserAddressFromWhitelistFunction)(removeUserAddressFromWhitelistFunction, cancellationToken)
        
        End Function
        Public Function VerifyUserAddressQueryAsync(ByVal verifyUserAddressFunction As VerifyUserAddressFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Boolean)
        
            Return ContractHandler.QueryAsync(Of VerifyUserAddressFunction, Boolean)(verifyUserAddressFunction, blockParameter)
        
        End Function

        
        Public Function VerifyUserAddressQueryAsync(ByVal [whitelistedAddress] As String, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Boolean)
        
            Dim verifyUserAddressFunction = New VerifyUserAddressFunction()
                verifyUserAddressFunction.WhitelistedAddress = [whitelistedAddress]
            
            Return ContractHandler.QueryAsync(Of VerifyUserAddressFunction, Boolean)(verifyUserAddressFunction, blockParameter)
        
        End Function


    
    End Class

End Namespace
