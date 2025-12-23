namespace WFD.Logic.Tests
{
    public class HelperTests
    {
        //Zasada 3a
        //1a- Arrange - zaranrzuj/przygotuj/zaplanuj
        //2a- Act - dzia³aj/wykonaj
        //3a- Assert - porównaj


        //nazwa(co testuje)_Co robi_oczekiwany wynik_dla jakich danych
        [Fact]
        public void IsWomen_ShouldReturn_True_ForCorrectData()
        {
            //Arrange - zaranrzuj/przygotuj/zaplanuj
            bool wynik;

            //Act - dzia³aj/wykonaj
            wynik = Helper.IsWomen("Ania");

            //Assert - porównaj
            Assert.True(wynik);

        }

        [Fact]
        public void IsWomen_ShouldReturn_False_ForIncorrectData()
        {
            //Arrange - zaranrzuj/przygotuj/zaplanuj
            bool wynik;

            //Act - dzia³aj/wykonaj
            wynik = Helper.IsWomen("Kamil");

            //Assert - porównaj
            Assert.False(wynik);
        }

        [Theory]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData("a", true)]
        [InlineData("Pawe³", false)]
        [InlineData("Ala", true)]
        [InlineData("Kuba", false)]
        [InlineData("asfuayfsgoagfy", false)]
        [InlineData("5452133553", false)]
        [InlineData("kuba ", false)]
        [InlineData("ala ", true)]
        [InlineData("ALA ", true)]
        [InlineData("ala ma kota", false)]
        [InlineData("KUBA", false)]
        [InlineData("KuBa ", false)]

        public void IsWomen_ShouldReturn_expectedValue_ForInput(string imie, bool oczekiwanyWynik)
        {

            //Arrange - zaranrzuj/przygotuj/zaplanuj
            bool wynik;

            //Act - dzia³aj/wykonaj
            wynik = Helper.IsWomen(imie);

            //Assert - porównaj
            Assert.Equal(oczekiwanyWynik, wynik);
        }
    }
}