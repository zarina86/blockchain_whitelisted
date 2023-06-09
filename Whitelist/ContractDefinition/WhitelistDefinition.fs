namespace White.Contracts.Whitelist.ContractDefinition

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes
open Nethereum.Web3
open Nethereum.RPC.Eth.DTOs
open Nethereum.Contracts.CQS
open Nethereum.Contracts
open System.Threading

    
    
    type WhitelistDeployment(byteCode: string) =
        inherit ContractDeploymentMessage(byteCode)
        
        static let BYTECODE = "608060405234801561001057600080fd5b506040516106e83803806106e883398101604081905261002f91610049565b600280546001600160a01b03191633179055600055610062565b60006020828403121561005b57600080fd5b5051919050565b610677806100716000396000f3fe608060405234801561001057600080fd5b506004361061009e5760003560e01c806391b173491161006657806391b173491461010a578063921a5b4814610112578063b0c8f9dc1461014e578063ba43654714610161578063bb9c6c3e1461016a57600080fd5b806358ef6747146100a357806372353033146100b85780637a662f8f146100d4578063893d20e8146100dc5780638cd5a0b9146100f7575b600080fd5b6100b66100b1366004610494565b61017d565b005b6100c160015481565b6040519081526020015b60405180910390f35b6001546100c1565b6002546040516001600160a01b0390911681526020016100cb565b6100b6610105366004610494565b6102e6565b6000546100c1565b61013e610120366004610494565b6001600160a01b031660009081526004602052604090205460ff1690565b60405190151581526020016100cb565b6100c161015c3660046104da565b6103db565b6100c160005481565b6100c16101783660046104da565b61043b565b6002546001600160a01b031633146101dc5760405162461bcd60e51b815260206004820152601e60248201527f4572726f723a2043616c6c6572206973206e6f7420746865206f776e6572000060448201526064015b60405180910390fd5b6001600160a01b03811660009081526004602052604090205460ff16156102545760405162461bcd60e51b815260206004820152602660248201527f4572726f723a2053656e64657220616c7265616479206265656e2077686974656044820152651b1a5cdd195960d21b60648201526084016101d3565b600054600154106102a75760405162461bcd60e51b815260206004820152601f60248201527f4572726f723a2057686974656c697374204c696d69742065786365656465640060448201526064016101d3565b6001600160a01b0381166000908152600460205260408120805460ff191660019081179091558054909182916102de9083906105a1565b909155505050565b6002546001600160a01b031633146103405760405162461bcd60e51b815260206004820152601e60248201527f4572726f723a2043616c6c6572206973206e6f7420746865206f776e6572000060448201526064016101d3565b6001600160a01b03811660009081526004602052604090205460ff166103a85760405162461bcd60e51b815260206004820181905260248201527f4572726f723a2053656e646572206973206e6f742077686974656c697374656460448201526064016101d3565b6001600160a01b0381166000908152600460205260408120805460ff1916905560018054909182916102de9083906105ba565b3360008181526004602052604081205490919060ff1661040d5760405162461bcd60e51b81526004016101d3906105cd565b6000429050806003856040516104239190610612565b90815260405190819003602001902055915050919050565b3360008181526004602052604081205490919060ff1661046d5760405162461bcd60e51b81526004016101d3906105cd565b60038360405161047d9190610612565b908152602001604051809103902054915050919050565b6000602082840312156104a657600080fd5b81356001600160a01b03811681146104bd57600080fd5b9392505050565b634e487b7160e01b600052604160045260246000fd5b6000602082840312156104ec57600080fd5b813567ffffffffffffffff8082111561050457600080fd5b818401915084601f83011261051857600080fd5b81358181111561052a5761052a6104c4565b604051601f8201601f19908116603f01168101908382118183101715610552576105526104c4565b8160405282815287602084870101111561056b57600080fd5b826020860160208301376000928101602001929092525095945050505050565b634e487b7160e01b600052601160045260246000fd5b808201808211156105b4576105b461058b565b92915050565b818103818111156105b4576105b461058b565b60208082526025908201527f57686974656c6973743a20596f75206e65656420746f2062652077686974656c6040820152641a5cdd195960da1b606082015260800190565b6000825160005b818110156106335760208186018101518583015201610619565b50600092019182525091905056fea26469706673582212201160474853e3b8c8ee0fe819ece1615298dd937b13cd7682482d1b7e9b0061b864736f6c63430008130033"
        
        new() = WhitelistDeployment(BYTECODE)
        
            [<Parameter("uint256", "_maxWhitelistedAddresses", 1)>]
            member val public MaxWhitelistedAddresses = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<Function("add", "uint256")>]
    type AddFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("string", "hash", 1)>]
            member val public Hash = Unchecked.defaultof<string> with get, set
        
    
    [<Function("addUserAddressToWhitelist")>]
    type AddUserAddressToWhitelistFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "_addressToWhitelist", 1)>]
            member val public AddressToWhitelist = Unchecked.defaultof<string> with get, set
        
    
    [<Function("getMaxNumberOfWhitelistedAddresses", "uint256")>]
    type GetMaxNumberOfWhitelistedAddressesFunction() = 
        inherit FunctionMessage()
    

        
    
    [<Function("getNumberOfWhitelistedAddresses", "uint256")>]
    type GetNumberOfWhitelistedAddressesFunction() = 
        inherit FunctionMessage()
    

        
    
    [<Function("getOwner", "address")>]
    type GetOwnerFunction() = 
        inherit FunctionMessage()
    

        
    
    [<Function("maxNumberOfWhitelistedAddresses", "uint256")>]
    type MaxNumberOfWhitelistedAddressesFunction() = 
        inherit FunctionMessage()
    

        
    
    [<Function("numberOfAddressesWhitelisted", "uint256")>]
    type NumberOfAddressesWhitelistedFunction() = 
        inherit FunctionMessage()
    

        
    
    [<Function("removeUserAddressFromWhitelist")>]
    type RemoveUserAddressFromWhitelistFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "_addressToRemove", 1)>]
            member val public AddressToRemove = Unchecked.defaultof<string> with get, set
        
    
    [<Function("verify", "uint256")>]
    type VerifyFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("string", "hash", 1)>]
            member val public Hash = Unchecked.defaultof<string> with get, set
        
    
    [<Function("verifyUserAddress", "bool")>]
    type VerifyUserAddressFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "_whitelistedAddress", 1)>]
            member val public WhitelistedAddress = Unchecked.defaultof<string> with get, set
        
    
    
    
    
    
    [<FunctionOutput>]
    type GetMaxNumberOfWhitelistedAddressesOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("uint256", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<FunctionOutput>]
    type GetNumberOfWhitelistedAddressesOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("uint256", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<FunctionOutput>]
    type GetOwnerOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("address", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<string> with get, set
        
    
    [<FunctionOutput>]
    type MaxNumberOfWhitelistedAddressesOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("uint256", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<FunctionOutput>]
    type NumberOfAddressesWhitelistedOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("uint256", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<BigInteger> with get, set
        
    
    
    
    [<FunctionOutput>]
    type VerifyOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("uint256", "dateAdded", 1)>]
            member val public DateAdded = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<FunctionOutput>]
    type VerifyUserAddressOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("bool", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<bool> with get, set
    

