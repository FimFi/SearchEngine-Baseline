using Microsoft.AspNetCore.Mvc;

namespace SearchAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        Database mDatabase;

        Dictionary<string, int> mWords;

        public SearchController(Database database)
        {
            mDatabase = database;
            mWords = mDatabase.GetAllWords();
        }

        [HttpGet("{id}")]
        public int GetIdOf(string word)
        {
            if (mWords.ContainsKey(word))
                return mWords[word];
            return -1;
        }
        [Route("[controller]/GetDocuments")]
        [HttpGet]
        public List<KeyValuePair<int, int>> GetDocuments([FromQuery]List<int> wordIds)
        {
            return mDatabase.GetDocuments(wordIds);
        }
        [HttpGet("getDocumentDetails")]
        public List<string> GetDocumentDetails([FromQuery] List<int> docIds)
        {
            return mDatabase.GetDocDetails(docIds);
        }
    }
}
