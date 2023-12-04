package com.qualitystream.tutorial;

import static org.junit.Assert.*;

import java.util.List;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

public class BuggyCars_RegisterUser_TAE {

	private WebDriver driver;
	
	By registerLinkLocator = By.linkText("Register");
	// Voy a usar el elemento <h2> con el texto Register with Buggy Cars Rating para determinar si me encuentro en la página de registro. 
	By registerPageLocator = By.xpath("//h2[text()='Register with Buggy Cars Rating']");
			
	By userNameLocator = By.id("username");
	By firstNameLocator = By.id("firstName");
	By lastNameLocator = By.id("lastName");
	By passwordLocator = By.id("password");
	By confirmPassLocator = By.cssSelector("input[name='confirmPassword']");
	By registerBtnLocator = By.className("btn-default");
	
	// Localizadores para login en la aplicacion
	By userLocator = By.name("login");
	By passLocator = By.name("password");
	By signInbtnLocator = By.xpath("/html/body/my-app/header/nav/div/my-login/div/form/button");
	
	By signPageLocator = By.linkText("Profile");

	// Localizadores para actualizar el perfil
	// para ubicar que estoy logeado voy a usar el identificador singPageLocator
	
	By currentPasswordLocator = By.id("currentPassword");
	By newPassLocator = By.id("newPassword");
	By newPassConfLocator = By.id("newPasswordConfirmation");
	By savePassBtn = By.xpath("/html/body/my-app/div/main/my-profile/div/form/div[2]/div/button");
	
	//Localizadores para votar por un vehiculo 
	By overallModelLocator = By.xpath("/html/body/my-app/div/main/my-home/div/div[3]/div/a/img");
	By carLinkLocator = By.linkText("Reventón");
	By comentSectionLocator = By.id("comment");
	By voteBtnLocator = By.xpath("/html/body/my-app/div/main/my-model/div/div[1]/div[3]/div[2]/div[2]/div/button");
	//By successVoteMessage = By.xpath("/html/body/my-app/div/main/my-model/div/div[1]/div[3]/div[2]/div[2]/p");
	
	@Before
	public void setUp() throws Exception {
		
		System.setProperty("webdriver.chrome.driver", "./src/test/resources/chromedriver/chromedriver.exe");
		driver = new ChromeDriver();
		driver.manage().window().maximize();
		driver.get("https://buggy.justtestit.org/");
			
		
	}

	@After
	public void tearDown() throws Exception {
	// driver.quit();
	}

	//@Test
	public void registerUser() throws Exception {
		
		driver.findElement(registerLinkLocator).click();
		Thread.sleep(2000); // 2 segundos de espera
		
		if(driver.findElement(registerPageLocator).isDisplayed()) {
			driver.findElement(userNameLocator).sendKeys("TAE_User009");
			driver.findElement(firstNameLocator).sendKeys("TAE_FN_User001");
			driver.findElement(lastNameLocator).sendKeys("TAE_LN_User001");
			driver.findElement(passwordLocator).sendKeys("Pass001$");
			driver.findElement(confirmPassLocator).sendKeys("Pass001$");
			
			driver.findElement(registerBtnLocator).click();
			
		}
		else {
			System.out.println("Register Page was not found");
		}
		
		//Valida que salga el mensaje de registro exitoso!!
		Thread.sleep(2000); // espero 2 segundos para que el mensaje salga en la pantalla
		//Encontrar el texto de registro exitoso a través de una lista que recupere todos los elementos div de la pagina
		List<WebElement> div = driver.findElements(By.xpath("/html/body/my-app/div/main/my-register/div/div/form/div"));
		//Comparativo entre el mensaje que debería salir y mensaje recuperado en la posicion 5 de los div de la pagina
		assertEquals("Registration is successful",div.get(5).getText());
				
		
	}
	
	
	//@Test
	public void signIn() throws Exception{
		if(driver.findElement(userLocator).isDisplayed()) {
			driver.findElement(userLocator).sendKeys("TAE_User007");
			driver.findElement(passLocator).sendKeys("Pass001$");
			
			driver.findElement(signInbtnLocator).click();
			Thread.sleep(4000); // espero 4 segundos para que el mensaje salga en la pantalla
			assertTrue(driver.findElement(signPageLocator).isDisplayed());
			
		}else {
			System.out.println("Profile link was not present");
		}		
	}
	
	//@Test
	public void updatePassword() throws Exception{
		driver.findElement(userLocator).sendKeys("TAE_User007");
		driver.findElement(passLocator).sendKeys("Pass003$");
		driver.findElement(signInbtnLocator).click();
		Thread.sleep(4000);
		
		if(driver.findElement(signPageLocator).isDisplayed()) {
			driver.findElement(signPageLocator).click();
			
			Thread.sleep(3000); // esperar 3 segundos para que cargue el formulario
			driver.findElement(currentPasswordLocator).sendKeys("Pass003$");
			driver.findElement(newPassLocator).sendKeys("Pass003$");
			driver.findElement(newPassConfLocator).sendKeys("Pass003$");
			driver.findElement(savePassBtn).click();
			Thread.sleep(6000);
			
			//Valida que salga el mensaje de cambio exitoso!!
			//Encontrar el texto de registro exitoso a través de una lista que recupere todos los elementos div de la pagina
			List<WebElement> div = driver.findElements(By.xpath("/html/body/my-app/div/main/my-profile/div/form/div[1]/div[1]/div"));
			//Comparativo entre el mensaje que debería salir y mensaje recuperado en la posicion 5 de los div de la pagina
			assertEquals("The profile has been saved successful",div.get(1).getText());
			
			
		}
		
		
	}
	
	
	@Test
	public void vote() throws Exception{
		// login en la aplicación 
		driver.findElement(userLocator).sendKeys("TAE_User009");
		driver.findElement(passLocator).sendKeys("Pass001$");
		driver.findElement(signInbtnLocator).click();
		Thread.sleep(4000);// esperar 4 segundos
		
		if(driver.findElement(overallModelLocator).isDisplayed()) {
			driver.findElement(overallModelLocator).click();
			
			Thread.sleep(3000); // esperar 3 segundos para que cargue el formulario
			driver.findElement(carLinkLocator).click();
			Thread.sleep(3000);// esperar 3 segundos
			
			
			//dejar comentario y votar
			driver.findElement(comentSectionLocator).sendKeys("TAE_Muy buen vehiculo");
			driver.findElement(voteBtnLocator).click();
			Thread.sleep(4000);// esperar 4 segundos
			


			//Valida que salga el mensaje de cambio exitoso!!
			//Encontrar el texto de registro exitoso a través de una lista que recupere todos los elementos div de la pagina
			By successVoteMessage = By.xpath("/html/body/my-app/div/main/my-model/div/div[1]/div[3]/div[2]/div[2]");
			//Comparativo entre el mensaje que debería salir y mensaje recuperado en la posicion 5 de los div de la pagina
			assertEquals("Thank you for your vote!",driver.findElement(successVoteMessage).getText());
			
			
		}
		
		
	}
	

}
