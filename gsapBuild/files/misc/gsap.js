const box1 = gsap.timeline();
const box2 = gsap.timeline();
const box3 = gsap.timeline();

box1.from("#img1", { duration: 1, y: -400, opacity: 0, ease: "power2", scale: 0,})
    .from("#img2", { duration: 1, y: -400, opacity: 0, ease: "power2", scale: 0,})
    .from("#img3", { duration: 1, y: -400, opacity: 0, ease: "power2", scale: 0 })
    .from("#img4", { duration: 1, y: -400, opacity: 0, ease: "power2", scale: 0 })
    .from("#img5", { duration: 1, opacity: 0, ease: "back", scale: 0 });

box1.to(".box1", { duration: 1, x: -550, ease: "power1", scale: 1 });

// VOLGENDE

box2.from("#img6", { duration: 1, y: -250, ease: "back", scale: 0 },"+=6")
    .from("#img7, #img8, #img9, #img10", {duration: 1, y: 250, ease: "power2", scale: 0})
    .from("#img11", {duration: 1, ease: "back.out(1.8)", scale: 0})
    .to(".box2", {duration: 1, x: 550, ease: "power1", scale: 1});

// VOLGENDE

box3.from("#img12", {duration: 1, ease: "back.inOut(2)", opacity: 0, scale: 0.5}, "+=10")
    .from("#img14", {duration: 1, ease: "power2.easeOut(2)", opacity:0, scale: 0})
    .from("#img15", {duration: 1, ease: "back.out(12)", opacity: 0, scale: 0})
    .from("#img16", {duration: 1, y: 700, ease: "power1.out(2)", opacity: 0, scale: 1})
    .from("#img17", {duration: 1, y: 700, ease: "power3.out(2)", opacity: 0, scale: 0})
    .from("#img13, #img18", {duration: 1, ease: "back.inOut(2)", opacity: 0, scale: 0})
    // .to(".box3", {duration: 1, y: -50, ease: "power1", scale: 1}, "+=2");