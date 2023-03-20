Imports System
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Numerics
Imports Nethereum.Hex.HexTypes
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports Nethereum.Web3
Imports Nethereum.RPC.Eth.DTOs
Imports Nethereum.Contracts.CQS
Imports Nethereum.Contracts
Imports System.Threading
Namespace White.Contracts.Whitelist.ContractDefinition

    
    
    Public Partial Class WhitelistDeployment
     Inherits WhitelistDeploymentBase
    
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
    
    End Class

    Public Class WhitelistDeploymentBase 
            Inherits ContractDeploymentMessage
        
        Public Shared DEFAULT_BYTECODE As String = "608060405234801561001057600080fd5b506040516104c33803806104c383398101604081905261002f91610049565b600280546001600160a01b03191633179055600055610062565b60006020828403121561005b57600080fd5b5051919050565b610452806100716000396000f3fe608060405234801561001057600080fd5b50600436106100935760003560e01c8063893d20e811610066578063893d20e81461010d5780638cd5a0b91461012857806391b173491461013b578063921a5b4814610098578063ba4365471461014357600080fd5b80633af32abf1461009857806358ef6747146100d957806372353033146100ee5780637a662f8f14610105575b600080fd5b6100c46100a63660046103aa565b6001600160a01b031660009081526004602052604090205460ff1690565b60405190151581526020015b60405180910390f35b6100ec6100e73660046103aa565b61014c565b005b6100f760015481565b6040519081526020016100d0565b6001546100f7565b6002546040516001600160a01b0390911681526020016100d0565b6100ec6101363660046103aa565b6102b5565b6000546100f7565b6100f760005481565b6002546001600160a01b031633146101ab5760405162461bcd60e51b815260206004820152601e60248201527f4572726f723a2043616c6c6572206973206e6f7420746865206f776e6572000060448201526064015b60405180910390fd5b6001600160a01b03811660009081526004602052604090205460ff16156102235760405162461bcd60e51b815260206004820152602660248201527f4572726f723a2053656e64657220616c7265616479206265656e2077686974656044820152651b1a5cdd195960d21b60648201526084016101a2565b600054600154106102765760405162461bcd60e51b815260206004820152601f60248201527f4572726f723a2057686974656c697374204c696d69742065786365656465640060448201526064016101a2565b6001600160a01b0381166000908152600460205260408120805460ff191660019081179091558054909182916102ad9083906103f0565b909155505050565b6002546001600160a01b0316331461030f5760405162461bcd60e51b815260206004820152601e60248201527f4572726f723a2043616c6c6572206973206e6f7420746865206f776e6572000060448201526064016101a2565b6001600160a01b03811660009081526004602052604090205460ff166103775760405162461bcd60e51b815260206004820181905260248201527f4572726f723a2053656e646572206973206e6f742077686974656c697374656460448201526064016101a2565b6001600160a01b0381166000908152600460205260408120805460ff1916905560018054909182916102ad908390610409565b6000602082840312156103bc57600080fd5b81356001600160a01b03811681146103d357600080fd5b9392505050565b634e487b7160e01b600052601160045260246000fd5b80820180821115610403576104036103da565b92915050565b81810381811115610403576104036103da56fea2646970667358221220ee29164f2c5289c149d90b7634040b2e542879e809479a050125ef7c2942bfbb64736f6c63430008130033"
        
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
        
        <[Parameter]("uint256", "_maxWhitelistedAddresses", 1)>
        Public Overridable Property [MaxWhitelistedAddresses] As BigInteger
    
    End Class    
    
    Public Partial Class AddUserAddressToWhitelistFunction
        Inherits AddUserAddressToWhitelistFunctionBase
    End Class

        <[Function]("addUserAddressToWhitelist")>
    Public Class AddUserAddressToWhitelistFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "_addressToWhitelist", 1)>
        Public Overridable Property [AddressToWhitelist] As String
    
    End Class
    
    
    Public Partial Class GetMaxNumberOfWhitelistedAddressesFunction
        Inherits GetMaxNumberOfWhitelistedAddressesFunctionBase
    End Class

        <[Function]("getMaxNumberOfWhitelistedAddresses", "uint256")>
    Public Class GetMaxNumberOfWhitelistedAddressesFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class GetNumberOfWhitelistedAddressesFunction
        Inherits GetNumberOfWhitelistedAddressesFunctionBase
    End Class

        <[Function]("getNumberOfWhitelistedAddresses", "uint256")>
    Public Class GetNumberOfWhitelistedAddressesFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class GetOwnerFunction
        Inherits GetOwnerFunctionBase
    End Class

        <[Function]("getOwner", "address")>
    Public Class GetOwnerFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class IsWhitelistedFunction
        Inherits IsWhitelistedFunctionBase
    End Class

        <[Function]("isWhitelisted", "bool")>
    Public Class IsWhitelistedFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "_whitelistedAddress", 1)>
        Public Overridable Property [WhitelistedAddress] As String
    
    End Class
    
    
    Public Partial Class MaxNumberOfWhitelistedAddressesFunction
        Inherits MaxNumberOfWhitelistedAddressesFunctionBase
    End Class

        <[Function]("maxNumberOfWhitelistedAddresses", "uint256")>
    Public Class MaxNumberOfWhitelistedAddressesFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class NumberOfAddressesWhitelistedFunction
        Inherits NumberOfAddressesWhitelistedFunctionBase
    End Class

        <[Function]("numberOfAddressesWhitelisted", "uint256")>
    Public Class NumberOfAddressesWhitelistedFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class RemoveUserAddressFromWhitelistFunction
        Inherits RemoveUserAddressFromWhitelistFunctionBase
    End Class

        <[Function]("removeUserAddressFromWhitelist")>
    Public Class RemoveUserAddressFromWhitelistFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "_addressToRemove", 1)>
        Public Overridable Property [AddressToRemove] As String
    
    End Class
    
    
    Public Partial Class VerifyUserAddressFunction
        Inherits VerifyUserAddressFunctionBase
    End Class

        <[Function]("verifyUserAddress", "bool")>
    Public Class VerifyUserAddressFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "_whitelistedAddress", 1)>
        Public Overridable Property [WhitelistedAddress] As String
    
    End Class
    
    
    
    
    Public Partial Class GetMaxNumberOfWhitelistedAddressesOutputDTO
        Inherits GetMaxNumberOfWhitelistedAddressesOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class GetMaxNumberOfWhitelistedAddressesOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class GetNumberOfWhitelistedAddressesOutputDTO
        Inherits GetNumberOfWhitelistedAddressesOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class GetNumberOfWhitelistedAddressesOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class GetOwnerOutputDTO
        Inherits GetOwnerOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class GetOwnerOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class IsWhitelistedOutputDTO
        Inherits IsWhitelistedOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class IsWhitelistedOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("bool", "", 1)>
        Public Overridable Property [ReturnValue1] As Boolean
    
    End Class    
    
    Public Partial Class MaxNumberOfWhitelistedAddressesOutputDTO
        Inherits MaxNumberOfWhitelistedAddressesOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class MaxNumberOfWhitelistedAddressesOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class NumberOfAddressesWhitelistedOutputDTO
        Inherits NumberOfAddressesWhitelistedOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class NumberOfAddressesWhitelistedOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    
    
    Public Partial Class VerifyUserAddressOutputDTO
        Inherits VerifyUserAddressOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class VerifyUserAddressOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("bool", "", 1)>
        Public Overridable Property [ReturnValue1] As Boolean
    
    End Class
End Namespace
