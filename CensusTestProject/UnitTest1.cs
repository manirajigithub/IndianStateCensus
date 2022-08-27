using IndianStateCensus.POCO;
using Newtonsoft.Json;
using NUnit.Framework;
using IndianStateCensus;
using IndianStateCensus.DTO;
namespace censusTestProject
{
    public class Tests
    {
        static string indianStateCensusHeaders = $"﻿State,Population,AreaInSqKm,DensityPerSqKm";
        static string indianStateCodeHeaders = $"SrNo,State Name,TIN,StateCode";
        static string wrongStateCensusHeaders = "﻿DensityPerSqKm,Population,AreaInSqKm,State";
        static string indianStateCensusFilePath = @"C:\Users\Asus\source\repos\IndianStateCensus\censusTestProject\CsvFiles\IndiaStateCensusData.csv";
        static string delimiterIndiaStateCensusDataFilePath = @"C:\Users\Asus\source\repos\IndianStateCensus\censusTestProject\CsvFiles\DelimiterIndiaStateCensusData.csv";
        static string delimiterIndiaStateCodeFilePath = @"C:\Users\Asus\source\repos\IndianStateCensus\censusTestProject\CsvFiles\DelimiterIndiaStateCode.csv";
        static string indiaStateCodeFilePath = @"C:\Users\Asus\source\repos\IndianStateCensus\censusTestProject\CsvFiles\IndiaStateCode.csv";
        static string wrongIndiaStateCensusDataFilePath = @"C:\Users\Asus\source\repos\IndianStateCensus\censusTestProject\CsvFiles\WrongIndiaStateCensusData.csv";
        static string wrongIndiaStateCodeFilePath = @"C:\Users\Asus\source\repos\IndianStateCensus\censusTestProject\CsvFiles\WrongIndiaStateCode.csv";
        CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;

        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();
        }

        [Test]
        public void GivenIndianCensusDataFile_WhenReade_ThenShouldReturnCensusDataCount()
        {
            totalRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            stateRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indiaStateCodeFilePath, indianStateCodeHeaders);
            Assert.That(totalRecord.Count, Is.EqualTo(30));
            Assert.That(stateRecord.Count, Is.EqualTo(37));

        }
    }
}
