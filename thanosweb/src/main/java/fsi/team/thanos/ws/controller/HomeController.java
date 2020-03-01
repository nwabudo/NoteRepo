package fsi.team.thanos.ws.controller;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HomeController {

	@GetMapping("/")
	public String home() {
		return ("<h1>Welcome</h1>");
	}
	@GetMapping("/user")
	public String about() {
		return ("<h1>About Us</h1>");
	}
	@GetMapping("/edit")
	public String editPage() {
		return ("<h1>Welcome Admin, Go Ahead in editing the Page</h1>");
	}
}
