using System;
using System.Collections.Generic;
using quoxent.Networks;
using quoxent.Networks.Setup;
using NBitcoin;

namespace quoxent
{
   internal class quoxentSetup
   {
      internal static quoxentSetup Instance = new quoxentSetup();

      internal CoinSetup Setup = new CoinSetup
      {
         FileNamePrefix = "quoxent",
         ConfigFileName = "quoxent.conf",
         Magic = "23-25-01-FE",
         CoinType = 105, // SLIP-0044: https://github.com/satoshilabs/slips/blob/master/slip-0044.md,
         PremineReward =36000000 ,
         PoWBlockReward = 50,
         PoSBlockReward = 50,
         LastPowBlock = 12500,
         GenesisText = "https://www.quoxent.com/", // The New York Times, 2020-04-16
         TargetSpacing = TimeSpan.FromSeconds(64),
         ProofOfStakeTimestampMask = 0x0000000F, // 0x0000003F // 64 sec
         PoSVersion = 4
      };

      internal NetworkSetup Main = new NetworkSetup
      {
         Name = "quoxentMain",
         RootFolderName = "quoxent",
         CoinTicker = "QUO",
         DefaultPort = 16178,
         DefaultRPCPort = 16174,
         DefaultAPIPort = 37221,
         PubKeyAddress = 58, // B https://en.bitcoin.it/wiki/List_of_address_prefixes
         ScriptAddress = 120, // b
         SecretAddress = 63,
         GenesisTime = 1589201035,
         GenesisNonce = 2279999,
         GenesisBits = 0x1E0FFFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "00000ccd0c9bfd3e8298b0ab0ee0360f344fc3b69fc1fb74e9b87b551da21079",
         HashMerkleRoot = "8147544ff61937f55c3373d22aebad365698c9b16d7e33346e935ce9e121ae15",
         DNS = new[] { "167.71.126.151" },
         Nodes = new[] { "167.71.126.151" },
         Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      internal NetworkSetup RegTest = new NetworkSetup
      {
         Name = "quoxentRegTest",
         RootFolderName = "quoxentregtest",
         CoinTicker = "TQUO",
         DefaultPort = 18444,
         DefaultRPCPort = 18442,
         DefaultAPIPort = 38221,
         PubKeyAddress = 111,
         ScriptAddress = 196,
         SecretAddress = 239,
         GenesisTime = 1587118950,
         GenesisNonce = 29172,
         GenesisBits = 0x1F00FFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "00009e8c195ceb5e35f4dce85f49e152b5eabcff6017ebf9f46c9690fc7c5b94",
         HashMerkleRoot = "1c45d60fa18c51fdc2b7a60c9402f87276d1be2843b46aa1d38a0def26813af8",
         //DNS = new[] { "seedregtest1.blc.blockcore.net", "seedregtest2.blc.blockcore.net", "seedregtest.blc.blockcore.net" },
        // Nodes = new[] { "89.10.227.34", "::1" },
         Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      internal NetworkSetup Test = new NetworkSetup
      {
         Name = "quoxentTest",
         RootFolderName = "quoxenttest",
         CoinTicker = "TQUO",
         DefaultPort = 26178,
         DefaultRPCPort = 26174,
         DefaultAPIPort = 38221,
         PubKeyAddress = 65,
         ScriptAddress = 196,
         SecretAddress = 65,
         GenesisTime = 1589201468,
         GenesisNonce = 47,
         GenesisBits = 0x1F0FFFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "00002d2751d59910492ac6236df4c090e399e3b98151759b940d62082372c524",
         HashMerkleRoot = "ab9631ac02b07e3297868dfe318cc4e5407d76a9757642aadc3163ca87f26d87",
         //DNS = new[] { "seedtest1.blc.blockcore.net", "seedtest2.blc.blockcore.net", "seedtest.blc.blockcore.net" },
         //Nodes = new[] { "89.10.227.34", "::1" },
         Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      public bool IsPoSv3()
      {
         return Setup.PoSVersion == 3;
      }

      public bool IsPoSv4()
      {
         return Setup.PoSVersion == 4;
      }
   }
}
