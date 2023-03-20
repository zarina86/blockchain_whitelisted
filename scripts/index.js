async function main () {
  const address = "0x077D64D3c75419B32f98577bfc1E111AE185B6AB";
  const Contract = await hre.ethers.getContractAt("Whitelist", address);
  //const contract = await Contract.attach(address);
  const added = await Contract.addUserAddressToWhitelist("0xF944C2cfcB6b719094e9101a56ab7d643DDC4b39");
  //const added = await token.addUserAddressToWhitelist("0xF944C2cfcB6b719094e9101a56ab7d643DDC4b39");
  
  console.log(added);

 
}

main()
  .then(() => process.exit(0))
  .catch(error => {
    console.error(error);
    process.exit(1);
  });