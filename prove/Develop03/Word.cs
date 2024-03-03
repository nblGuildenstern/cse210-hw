public class Word {
    private string word;
    private bool isHidden;

    public Word(string word) {
        this.word = word;
        isHidden = true;
    }

    public void HideWord() {
        string newWord = "";
        for(int i = 0; i < word.Length; i++) {
            newWord += "_";
        }
        isHidden = true;
        word = newWord;
    }

    public string GetWord() {
        return word;
    }
}