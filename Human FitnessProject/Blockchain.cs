using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Human_FitnessProject
{
    public class Blockchain
    {
        public IList<Block> Chain { set; get; }
        public int Difficulty { set; get; } = 2;
        public Blockchain()
        {
            InitializeChain();
            AddGenesisBlock();
        }


        public void InitializeChain()
        {
            Chain = new List<Block>();
        }

        public Block CreateGenesisBlock()
        {
            return new Block(DateTime.Now, null, "{}");
        }

        public void AddGenesisBlock()
        {
            Chain.Add(CreateGenesisBlock());
        }

        public Block GetLatestBlock()
        {
            return Chain[Chain.Count - 1];
        }

        public Block GetGenesisBlock()
        {
            return Chain[0];
        }

        
        public void AddBlock(Block block)
        {
            Block latestBlock = GetLatestBlock();
            block.Index = latestBlock.Index + 1;
            block.PreviousHash = latestBlock.Hash;
            block.Hash = block.CalculateHash();
            block.Mine(this.Difficulty);
            Chain.Add(block);
        }
        public void PrintGenesis()
        {
            Block GenesisBlock = GetGenesisBlock();
            Console.Clear();
            Console.WriteLine(JsonConvert.SerializeObject(GenesisBlock, Formatting.Indented));
        }
        public void PrintLatest()
        {
            Block latestBlock = GetLatestBlock();
            Console.Clear();
            Console.WriteLine(JsonConvert.SerializeObject(latestBlock, Formatting.Indented));
        }

        public bool IsValid()
        {
            for (int i = 1; i < Chain.Count; i++)
            {
                Block currentBlock = Chain[i];
                Block previousBlock = Chain[i - 1];

                if (currentBlock.Hash != currentBlock.CalculateHash())
                {
                    return false;
                }

                if (currentBlock.PreviousHash != previousBlock.Hash)
                {
                    return false;
                }
            }
            return true;
        }

       }
}
